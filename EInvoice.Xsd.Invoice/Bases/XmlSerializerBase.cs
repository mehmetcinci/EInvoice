using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.Bases {
    public abstract class XmlSerializerBase<T> {
        private static XmlSerializer _serializer;
        private static XmlSerializer SerializerXML {
            get {
                if ((_serializer == null)) {
                    _serializer = new XmlSerializerFactory().CreateSerializer(typeof(T));
                }
                return _serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serialize T object
        /// </summary>
        /// <returns>XML value</returns>
        public virtual string Serialize() {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try {
                memoryStream = new MemoryStream();
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;                

                XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
                XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
                xmlSerializerNamespaces.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
                xmlSerializerNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                xmlSerializerNamespaces.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
                xmlSerializerNamespaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                xmlSerializerNamespaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                xmlSerializerNamespaces.Add(string.Empty, "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");                
                SerializerXML.Serialize(xmlWriter, this, xmlSerializerNamespaces);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally {
                if ((streamReader != null)) {
                    streamReader.Dispose();
                }
                if ((memoryStream != null)) {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes T object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output T object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out T obj, out Exception exception) {
            exception = null;
            obj = default(T);
            try {
                obj = Deserialize(input);
                return true;
            }
            catch (Exception ex) {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string input, out T obj) {
            Exception exception = null;
            return Deserialize(input, out obj, out exception);
        }

        public static T Deserialize(string input) {
            StringReader stringReader = null;
            try {
                stringReader = new StringReader(input);
                return ((T)(SerializerXML.Deserialize(XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }

        public static T Deserialize(Stream s) {
            return ((T)(SerializerXML.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current T object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out Exception exception) {
            exception = null;
            try {
                SaveToFile(fileName);
                return true;
            }
            catch (Exception e) {
                exception = e;
                return false;
            }
        }

        public virtual void SaveToFile(string fileName) {
            StreamWriter streamWriter = null;
            try {
                string dataString = Serialize();
                FileInfo outputFile = new FileInfo(fileName);
                streamWriter = outputFile.CreateText();
                streamWriter.WriteLine(dataString);
                streamWriter.Close();
            }
            finally {
                if ((streamWriter != null)) {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an T object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output T object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out T obj, out Exception exception) {
            exception = null;
            obj = default(T);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex) {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out T obj) {
            Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static T LoadFromFile(string fileName) {
            FileStream file = null;
            StreamReader sr = null;
            try {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                string dataString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(dataString);
            }
            finally {
                if ((file != null)) {
                    file.Dispose();
                }
                if ((sr != null)) {
                    sr.Dispose();
                }
            }
        }
    }
}