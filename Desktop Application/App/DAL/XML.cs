using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XML
    {


        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class configuration
        {

            private configurationConnectiondb connectiondbField;

            private configurationWebserviceclient webserviceclientField;

            /// <remarks/>
            public configurationConnectiondb connectiondb
            {
                get
                {
                    return this.connectiondbField;
                }
                set
                {
                    this.connectiondbField = value;
                }
            }

            /// <remarks/>
            public configurationWebserviceclient webserviceclient
            {
                get
                {
                    return this.webserviceclientField;
                }
                set
                {
                    this.webserviceclientField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationConnectiondb
        {

            private string dbnameField;

            private string servernameField;

            private string usernameField;

            private string passwordField;

            /// <remarks/>
            public string dbname
            {
                get
                {
                    return this.dbnameField;
                }
                set
                {
                    this.dbnameField = value;
                }
            }

            /// <remarks/>
            public string servername
            {
                get
                {
                    return this.servernameField;
                }
                set
                {
                    this.servernameField = value;
                }
            }

            /// <remarks/>
            public string username
            {
                get
                {
                    return this.usernameField;
                }
                set
                {
                    this.usernameField = value;
                }
            }

            /// <remarks/>
            public string password
            {
                get
                {
                    return this.passwordField;
                }
                set
                {
                    this.passwordField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class configurationWebserviceclient
        {

            private string soapurlField;

            private string resturlField;

            /// <remarks/>
            public string soapurl
            {
                get
                {
                    return this.soapurlField;
                }
                set
                {
                    this.soapurlField = value;
                }
            }

            /// <remarks/>
            public string resturl
            {
                get
                {
                    return this.resturlField;
                }
                set
                {
                    this.resturlField = value;
                }
            }
        }


    }
}
