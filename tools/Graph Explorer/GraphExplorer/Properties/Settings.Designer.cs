﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocratexGraphExplorer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("neo4j")]
        public string Username {
            get {
                return ((string)(this["Username"]));
            }
            set {
                this["Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public int QueryFontSize {
            get {
                return ((int)(this["QueryFontSize"]));
            }
            set {
                this["QueryFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Consolas")]
        public string QueryFont {
            get {
                return ((string)(this["QueryFont"]));
            }
            set {
                this["QueryFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7687")]
        public int Port {
            get {
                return ((int)(this["Port"]));
            }
            set {
                this["Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string Server {
            get {
                return ((string)(this["Server"]));
            }
            set {
                this["Server"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Socratex Graph Explorer")]
        public string AppTitle {
            get {
                return ((string)(this["AppTitle"]));
            }
            set {
                this["AppTitle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ConnectResultNodes {
            get {
                return ((bool)(this["ConnectResultNodes"]));
            }
            set {
                this["ConnectResultNodes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<html>\r\n    <head>\r\n        <title>DataViz</title>\r\n        <style type=\'text/css" +
            "\'>\r\n            #viz {\r\n                width: 750px;\r\n                height: 6" +
            "00px;\r\n                border: 1px solid lightgray;\r\n                font: 12pt " +
            "arial;\r\n            }\r\n        </style>\r\n        <script src=\'https://rawgit.com" +
            "/neo4j-contrib/neovis.js/master/dist/neovis.js\'></script>\r\n    </head>\r\n    <scr" +
            "ipt>\r\n\r\n\r\n        function init()\r\n        {\r\n            (async function()\r\n   " +
            "         {\r\n                await CefSharp.BindObjectAsync(\'csObject\').then(func" +
            "tion(res) \r\n                {    // The promise is resolved when the object is a" +
            "vailable.\r\n                     // Objects are created in the global context (pr" +
            "operties of the window object).\r\n                     window.csObject.show(\'bana" +
            "na\').then(function(res)\r\n                     {\r\n                     })\r\n      " +
            "          });\r\n            })();\r\n        }\r\n\r\n        function setVizSize(width" +
            ", height)\r\n        {\r\n            document.getElementById(\'viz\').style.width = w" +
            "idth + \"px\";\r\n            document.getElementById(\'viz\').style.height = height +" +
            " \"px\";\r\n        }\r\n\r\n        function NodeOrEdgeSelected(event) {\r\n            w" +
            "indow.csObject.select(event.nodes[0], event.edges[0]);\r\n        }\r\n\r\n        fun" +
            "ction draw(cypher) {\r\n            var config = {\r\n                container_id: " +
            "\'viz\',\r\n                server_url: \'bolt://{Server}:{Port}\',\r\n                s" +
            "erver_user: \'{Username}\',\r\n                server_password: \'{Password}\',\r\n     " +
            "           arrows: true, // Shows arrows on edges\r\n                labels: {\r\n  " +
            "                  \'Class\': {\r\n                        caption: \'Name\', // Works." +
            " Name of property on Class node\r\n                        size: \'LOC\' ,\r\n        " +
            "                community: \'Package\',\r\n\r\n                        // This is what" +
            " gets shown in the tooltip\r\n                        \'title_properties\': [\r\n     " +
            "                       \'Name\', \'LOC\'\r\n                        ],\r\n\r\n            " +
            "            // \'sizeCypher\': \'MATCH (n) WHERE id(n) = {id} MATCH (n)-[r]-() RETU" +
            "RN sum(r.weight) AS c\'\r\n                        // \'sizeCypher\': \'MATCH (n) RETU" +
            "RN n.LOC as c\'\r\n                    },\r\n                    \'Method\': {\r\n       " +
            "                 // This is what gets shown in the tooltip\r\n                    " +
            "    \'title_properties\': [\r\n                            \'Method\', \'LOC\', \'NOS\'\r\n " +
            "                       ],\r\n                        caption: \'Method\', // Works. " +
            "Name of property on Method node\r\n                        size: \'LOC\',\r\n         " +
            "           }\r\n                },\r\n                relationships: {\r\n            " +
            "        \'EXTENDS\': {\r\n                        caption: true,  // Works\r\n        " +
            "            },\r\n                    \'DECLARES\': {\r\n                        capti" +
            "on: true,  // Works\r\n                    },\r\n                    \'CALLS\': {\r\n   " +
            "                     \'title_properties\': [\r\n                            \'Count\'\r" +
            "\n                        ],\r\n                        caption: true,  // Works\r\n " +
            "                       thickness: \'Count\', // Need a property name on the edge\r\n" +
            "\r\n                    }\r\n                },\r\n                initial_cypher: cyp" +
            "her\r\n            }\r\n            var viz = new NeoVis.default(config);\r\n         " +
            "   viz.registerOnEvent(\'completed\', (e)=>\r\n            {\r\n                viz[\'_" +
            "network\'].on(\'click\', (event)=>\r\n                {\r\n                    NodeOrEd" +
            "geSelected(event);\r\n                    console.log(event.nodes[0]);\r\n          " +
            "      });\r\n            });\r\n\r\n            // Do the actual drawing\r\n            " +
            "viz.render();\r\n        }\r\n    </script>\r\n\r\n    <body onload=\'init()\' >\r\n        " +
            "<div id=\'viz\'></div>\r\n    </body>\r\n</html>")]
        public string Configuration {
            get {
                return ((string)(this["Configuration"]));
            }
            set {
                this["Configuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public int SourceFontSize {
            get {
                return ((int)(this["SourceFontSize"]));
            }
            set {
                this["SourceFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Consolas")]
        public string SourceFont {
            get {
                return ((string)(this["SourceFont"]));
            }
            set {
                this["SourceFont"] = value;
            }
        }
    }
}