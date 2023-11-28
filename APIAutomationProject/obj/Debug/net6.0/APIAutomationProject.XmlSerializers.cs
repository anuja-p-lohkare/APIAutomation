[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"a7afaf56-e96e-4a00-a899-d1cc46494285,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write10_RestClientHelper(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"RestClientHelper", @"");
                return;
            }
            TopLevelElement();
            Write2_RestClientHelper(@"RestClientHelper", @"", ((global::RestSharpAutomation.HelperClass.Request.RestClientHelper)o), true, false);
        }

        public void Write11_JsonReader(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"JsonReader", @"");
                return;
            }
            TopLevelElement();
            Write3_JsonReader(@"JsonReader", @"", ((global::APIAutomationProject.Utilities.JsonReader)o), true, false);
        }

        public void Write12_APITests(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"APITests", @"");
                return;
            }
            TopLevelElement();
            Write4_APITests(@"APITests", @"", ((global::APIAutomationProject.Tests.APITests)o), true, false);
        }

        public void Write13_GetUser(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"GetUser", @"");
                return;
            }
            TopLevelElement();
            Write5_GetUser(@"GetUser", @"", ((global::APIAutomationProject.Models.GetUser)o), true, false);
        }

        public void Write14_DeleteRequest(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"DeleteRequest", @"");
                return;
            }
            TopLevelElement();
            Write6_DeleteRequest(@"DeleteRequest", @"", ((global::APIAutomationProject.APIRequests.DeleteRequest)o), true, false);
        }

        public void Write15_GetRequest(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"GetRequest", @"");
                return;
            }
            TopLevelElement();
            Write7_GetRequest(@"GetRequest", @"", ((global::APIAutomationProject.APIRequests.GetRequest)o), true, false);
        }

        public void Write16_PostRequest(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"PostRequest", @"");
                return;
            }
            TopLevelElement();
            Write8_PostRequest(@"PostRequest", @"", ((global::APIAutomationProject.APIRequests.PostRequest)o), true, false);
        }

        public void Write17_PutRequest(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"PutRequest", @"");
                return;
            }
            TopLevelElement();
            Write9_PutRequest(@"PutRequest", @"", ((global::APIAutomationProject.APIRequests.PutRequest)o), true, false);
        }

        void Write9_PutRequest(string n, string ns, global::APIAutomationProject.APIRequests.PutRequest o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::APIAutomationProject.APIRequests.PutRequest)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PutRequest", @"");
            WriteEndElement(o);
        }

        void Write8_PostRequest(string n, string ns, global::APIAutomationProject.APIRequests.PostRequest o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::APIAutomationProject.APIRequests.PostRequest)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PostRequest", @"");
            WriteEndElement(o);
        }

        void Write7_GetRequest(string n, string ns, global::APIAutomationProject.APIRequests.GetRequest o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::APIAutomationProject.APIRequests.GetRequest)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GetRequest", @"");
            WriteEndElement(o);
        }

        void Write6_DeleteRequest(string n, string ns, global::APIAutomationProject.APIRequests.DeleteRequest o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::APIAutomationProject.APIRequests.DeleteRequest)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DeleteRequest", @"");
            WriteEndElement(o);
        }

        void Write5_GetUser(string n, string ns, global::APIAutomationProject.Models.GetUser o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::APIAutomationProject.Models.GetUser)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GetUser", @"");
            WriteElementStringRaw(@"id", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@id)));
            WriteElementString(@"email", @"", ((global::System.String)o.@email));
            WriteElementString(@"first_name", @"", ((global::System.String)o.@first_name));
            WriteElementString(@"last_name", @"", ((global::System.String)o.@last_name));
            WriteElementString(@"avatar", @"", ((global::System.String)o.@avatar));
            WriteElementString(@"support", @"", ((global::System.String)o.@support));
            WriteElementString(@"text", @"", ((global::System.String)o.@text));
            WriteEndElement(o);
        }

        void Write4_APITests(string n, string ns, global::APIAutomationProject.Tests.APITests o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::APIAutomationProject.Tests.APITests)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"APITests", @"");
            WriteEndElement(o);
        }

        void Write3_JsonReader(string n, string ns, global::APIAutomationProject.Utilities.JsonReader o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::APIAutomationProject.Utilities.JsonReader)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"JsonReader", @"");
            WriteEndElement(o);
        }

        void Write2_RestClientHelper(string n, string ns, global::RestSharpAutomation.HelperClass.Request.RestClientHelper o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::RestSharpAutomation.HelperClass.Request.RestClientHelper)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"RestClientHelper", @"");
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read10_RestClientHelper() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id1_RestClientHelper && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read2_RestClientHelper(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":RestClientHelper");
            }
            return (object)o;
        }

        public object Read11_JsonReader() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id3_JsonReader && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read3_JsonReader(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":JsonReader");
            }
            return (object)o;
        }

        public object Read12_APITests() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id4_APITests && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read4_APITests(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":APITests");
            }
            return (object)o;
        }

        public object Read13_GetUser() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id5_GetUser && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read5_GetUser(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":GetUser");
            }
            return (object)o;
        }

        public object Read14_DeleteRequest() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id6_DeleteRequest && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read6_DeleteRequest(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":DeleteRequest");
            }
            return (object)o;
        }

        public object Read15_GetRequest() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id7_GetRequest && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read7_GetRequest(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":GetRequest");
            }
            return (object)o;
        }

        public object Read16_PostRequest() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id8_PostRequest && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read8_PostRequest(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":PostRequest");
            }
            return (object)o;
        }

        public object Read17_PutRequest() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id9_PutRequest && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read9_PutRequest(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":PutRequest");
            }
            return (object)o;
        }

        global::APIAutomationProject.APIRequests.PutRequest Read9_PutRequest(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_PutRequest && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::APIAutomationProject.APIRequests.PutRequest o;
            o = new global::APIAutomationProject.APIRequests.PutRequest();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::APIAutomationProject.APIRequests.PostRequest Read8_PostRequest(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_PostRequest && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::APIAutomationProject.APIRequests.PostRequest o;
            o = new global::APIAutomationProject.APIRequests.PostRequest();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::APIAutomationProject.APIRequests.GetRequest Read7_GetRequest(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_GetRequest && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::APIAutomationProject.APIRequests.GetRequest o;
            o = new global::APIAutomationProject.APIRequests.GetRequest();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::APIAutomationProject.APIRequests.DeleteRequest Read6_DeleteRequest(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_DeleteRequest && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::APIAutomationProject.APIRequests.DeleteRequest o;
            o = new global::APIAutomationProject.APIRequests.DeleteRequest();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::APIAutomationProject.Models.GetUser Read5_GetUser(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id5_GetUser && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::APIAutomationProject.Models.GetUser o;
            o = new global::APIAutomationProject.Models.GetUser();
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id10_id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@id = System.Xml.XmlConvert.ToInt32(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id11_email && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@email = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id12_first_name && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@first_name = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id13_last_name && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@last_name = Reader.ReadElementString();
                            }
                            paramsRead[3] = true;
                            break;
                        }
                        if (!paramsRead[4] && ((object) Reader.LocalName == (object)id14_avatar && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@avatar = Reader.ReadElementString();
                            }
                            paramsRead[4] = true;
                            break;
                        }
                        if (!paramsRead[5] && ((object) Reader.LocalName == (object)id15_support && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@support = Reader.ReadElementString();
                            }
                            paramsRead[5] = true;
                            break;
                        }
                        if (!paramsRead[6] && ((object) Reader.LocalName == (object)id16_text && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@text = Reader.ReadElementString();
                            }
                            paramsRead[6] = true;
                            break;
                        }
                        UnknownNode((object)o, @":id, :email, :first_name, :last_name, :avatar, :support, :text");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":id, :email, :first_name, :last_name, :avatar, :support, :text");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::APIAutomationProject.Tests.APITests Read4_APITests(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_APITests && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::APIAutomationProject.Tests.APITests o;
            o = new global::APIAutomationProject.Tests.APITests();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::APIAutomationProject.Utilities.JsonReader Read3_JsonReader(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_JsonReader && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::APIAutomationProject.Utilities.JsonReader o;
            o = new global::APIAutomationProject.Utilities.JsonReader();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::RestSharpAutomation.HelperClass.Request.RestClientHelper Read2_RestClientHelper(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_RestClientHelper && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::RestSharpAutomation.HelperClass.Request.RestClientHelper o;
            o = new global::RestSharpAutomation.HelperClass.Request.RestClientHelper();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id10_id;
        string id9_PutRequest;
        string id13_last_name;
        string id11_email;
        string id2_Item;
        string id1_RestClientHelper;
        string id5_GetUser;
        string id8_PostRequest;
        string id7_GetRequest;
        string id16_text;
        string id15_support;
        string id6_DeleteRequest;
        string id3_JsonReader;
        string id12_first_name;
        string id14_avatar;
        string id4_APITests;

        protected override void InitIDs() {
            id10_id = Reader.NameTable.Add(@"id");
            id9_PutRequest = Reader.NameTable.Add(@"PutRequest");
            id13_last_name = Reader.NameTable.Add(@"last_name");
            id11_email = Reader.NameTable.Add(@"email");
            id2_Item = Reader.NameTable.Add(@"");
            id1_RestClientHelper = Reader.NameTable.Add(@"RestClientHelper");
            id5_GetUser = Reader.NameTable.Add(@"GetUser");
            id8_PostRequest = Reader.NameTable.Add(@"PostRequest");
            id7_GetRequest = Reader.NameTable.Add(@"GetRequest");
            id16_text = Reader.NameTable.Add(@"text");
            id15_support = Reader.NameTable.Add(@"support");
            id6_DeleteRequest = Reader.NameTable.Add(@"DeleteRequest");
            id3_JsonReader = Reader.NameTable.Add(@"JsonReader");
            id12_first_name = Reader.NameTable.Add(@"first_name");
            id14_avatar = Reader.NameTable.Add(@"avatar");
            id4_APITests = Reader.NameTable.Add(@"APITests");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    public sealed class RestClientHelperSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"RestClientHelper", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write10_RestClientHelper(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read10_RestClientHelper();
        }
    }

    public sealed class JsonReaderSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"JsonReader", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write11_JsonReader(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read11_JsonReader();
        }
    }

    public sealed class APITestsSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"APITests", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write12_APITests(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read12_APITests();
        }
    }

    public sealed class GetUserSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"GetUser", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write13_GetUser(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read13_GetUser();
        }
    }

    public sealed class DeleteRequestSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"DeleteRequest", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write14_DeleteRequest(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read14_DeleteRequest();
        }
    }

    public sealed class GetRequestSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"GetRequest", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write15_GetRequest(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read15_GetRequest();
        }
    }

    public sealed class PostRequestSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"PostRequest", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write16_PostRequest(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read16_PostRequest();
        }
    }

    public sealed class PutRequestSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"PutRequest", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write17_PutRequest(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read17_PutRequest();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"RestSharpAutomation.HelperClass.Request.RestClientHelper::"] = @"Read10_RestClientHelper";
                    _tmp[@"APIAutomationProject.Utilities.JsonReader::"] = @"Read11_JsonReader";
                    _tmp[@"APIAutomationProject.Tests.APITests::"] = @"Read12_APITests";
                    _tmp[@"APIAutomationProject.Models.GetUser::"] = @"Read13_GetUser";
                    _tmp[@"APIAutomationProject.APIRequests.DeleteRequest::"] = @"Read14_DeleteRequest";
                    _tmp[@"APIAutomationProject.APIRequests.GetRequest::"] = @"Read15_GetRequest";
                    _tmp[@"APIAutomationProject.APIRequests.PostRequest::"] = @"Read16_PostRequest";
                    _tmp[@"APIAutomationProject.APIRequests.PutRequest::"] = @"Read17_PutRequest";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"RestSharpAutomation.HelperClass.Request.RestClientHelper::"] = @"Write10_RestClientHelper";
                    _tmp[@"APIAutomationProject.Utilities.JsonReader::"] = @"Write11_JsonReader";
                    _tmp[@"APIAutomationProject.Tests.APITests::"] = @"Write12_APITests";
                    _tmp[@"APIAutomationProject.Models.GetUser::"] = @"Write13_GetUser";
                    _tmp[@"APIAutomationProject.APIRequests.DeleteRequest::"] = @"Write14_DeleteRequest";
                    _tmp[@"APIAutomationProject.APIRequests.GetRequest::"] = @"Write15_GetRequest";
                    _tmp[@"APIAutomationProject.APIRequests.PostRequest::"] = @"Write16_PostRequest";
                    _tmp[@"APIAutomationProject.APIRequests.PutRequest::"] = @"Write17_PutRequest";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"APIAutomationProject.Utilities.JsonReader::", new JsonReaderSerializer());
                    _tmp.Add(@"APIAutomationProject.APIRequests.GetRequest::", new GetRequestSerializer());
                    _tmp.Add(@"APIAutomationProject.Tests.APITests::", new APITestsSerializer());
                    _tmp.Add(@"RestSharpAutomation.HelperClass.Request.RestClientHelper::", new RestClientHelperSerializer());
                    _tmp.Add(@"APIAutomationProject.Models.GetUser::", new GetUserSerializer());
                    _tmp.Add(@"APIAutomationProject.APIRequests.DeleteRequest::", new DeleteRequestSerializer());
                    _tmp.Add(@"APIAutomationProject.APIRequests.PostRequest::", new PostRequestSerializer());
                    _tmp.Add(@"APIAutomationProject.APIRequests.PutRequest::", new PutRequestSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::RestSharpAutomation.HelperClass.Request.RestClientHelper)) return true;
            if (type == typeof(global::APIAutomationProject.Utilities.JsonReader)) return true;
            if (type == typeof(global::APIAutomationProject.Tests.APITests)) return true;
            if (type == typeof(global::APIAutomationProject.Models.GetUser)) return true;
            if (type == typeof(global::APIAutomationProject.APIRequests.DeleteRequest)) return true;
            if (type == typeof(global::APIAutomationProject.APIRequests.GetRequest)) return true;
            if (type == typeof(global::APIAutomationProject.APIRequests.PostRequest)) return true;
            if (type == typeof(global::APIAutomationProject.APIRequests.PutRequest)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::RestSharpAutomation.HelperClass.Request.RestClientHelper)) return new RestClientHelperSerializer();
            if (type == typeof(global::APIAutomationProject.Utilities.JsonReader)) return new JsonReaderSerializer();
            if (type == typeof(global::APIAutomationProject.Tests.APITests)) return new APITestsSerializer();
            if (type == typeof(global::APIAutomationProject.Models.GetUser)) return new GetUserSerializer();
            if (type == typeof(global::APIAutomationProject.APIRequests.DeleteRequest)) return new DeleteRequestSerializer();
            if (type == typeof(global::APIAutomationProject.APIRequests.GetRequest)) return new GetRequestSerializer();
            if (type == typeof(global::APIAutomationProject.APIRequests.PostRequest)) return new PostRequestSerializer();
            if (type == typeof(global::APIAutomationProject.APIRequests.PutRequest)) return new PutRequestSerializer();
            return null;
        }
    }
}
