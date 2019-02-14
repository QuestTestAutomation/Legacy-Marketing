using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DellQA.Common.Enums
{
    public struct Commands
    {
        public const string Navigate = "navigate";
        public const string Verify = "verify";
        public const string pagerefresh = "pagerefresh";
        public const string COMPAREURL = "compareurl";
        public const string CLICKANDTYPEBYID = "clickandtypebyid";
        public const string SWITCH_TO = "switch_to";
        public const string NEWTAB = "newtab";
        public const string CLICK = "click";
        public const string DB_CHECK = "db_check";
        public const string TYPE = "type";
        public const string STATUSCODE = "statuscode";
        public const string IFRAME = "iframe";
        public const string CLEARCOOKIES = "clearcookies";
        public const string PARTIALLINK = "partiallink";
        public const string CLOSECURRENTTAB = "closecurrenttab";
        public const string CURWINDHANDLE = "curwindhandle";
        public const string GETCURRENTURL = "getcurrenturl";
        public const string GETTEXT = "gettext";
        public const string PASTETEXT = "pastetext";
        public const string GETEMAIL_GURLLA = "getemail_gurlla";
        public const string VERIFYEMAIL_GURLLA = "verifyemail_gurlla";
        public const string SEARCHBYMAIL = "searchbymail";
        public const string SELECTBYTEXT = "selectbytext";
        public const string SELECTBYVALUE = "selectbyvalue";
        public const string SELECTAUTOFILL = "selectautofill";
        public const string DATETIME = "datetime";
        public const string SWITCHTO = "switchto";
        public const string SILVERLIGHT = "silverlight";
        public const string FILEUPLOAD = "fileupload";
        public const string ALERTCLOSE = "alertclose";
        public const string DIGIEVENT = "digievent";
        public const string GETRACKINGID = "gatrackingid";
        public const string SITECAT = "sitecat";
    }
}
