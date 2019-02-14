using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSelenium.Utils
{
    public class Locators
    {
        
            static Locators()
            {
                LoadNavigationList();
                LoadClickNameList();
                LoadTypeNameList();
                LoadXpathClickList();
                LoadXpathTypeList();
                LoadCParlnkClickList();
                LoadidautofillSelectList();
                LoadidselbyvalueList();
                LoadhrdnewtabList();
                LoadGetmaillist();
                Loadidtxtpastelist();
                LoadChrd_switchList();
                Loaddatetimelist();
                Loadverifytxtlist();

                /////////////////////////Data////////////////////////////
                iddatatype();
                selectbyvalue();
                autofilldata();
                xpathdatatype();
            }
            protected static Dictionary<string, string> lstNavigate = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstClick = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstType = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstXpath = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstDateTime = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstXpathtype = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstParlnk = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstIDAutofill = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstIdbyValue = new Dictionary<string, string>();
            protected static Dictionary<string, string> lsthrdnewtab = new Dictionary<string, string>();
            protected static Dictionary<string, string> lsgetmailgurilla = new Dictionary<string, string>();
            protected static Dictionary<string, string> lidtxtpaste = new Dictionary<string, string>();
            protected static Dictionary<string, string> lswtichto = new Dictionary<string, string>();
            protected static Dictionary<string, string> lstIdbytxt = new Dictionary<string, string>();
            ///////////////////////Data///////////////////////
            protected static Dictionary<string, string> lddata = new Dictionary<string, string>();
            protected static Dictionary<string, string> lddatabyValue = new Dictionary<string, string>();
            protected static Dictionary<string, string> ldautofilldata = new Dictionary<string, string>();
            protected static Dictionary<string, string> xpathdata = new Dictionary<string, string>();
            protected static Dictionary<string, string> lsverifytxt = new Dictionary<string, string>();
            protected static Dictionary<string, string> lddatabytxt = new Dictionary<string, string>();
            public string hrd_navigate(string hrd_navigate)
            {
                if (lstNavigate.ContainsKey(hrd_navigate))
                {
                    return lstNavigate[hrd_navigate];
                }
                return null;
            }
            public string idclick(string idclick)
            {
                if (lstClick.ContainsKey(idclick))
                {
                    return lstClick[idclick];
                }
                return null;
            }
            public string idtype(string idtype)
            {
                if (lstType.ContainsKey(idtype))
                {
                    return lstType[idtype];
                }
                return null;
            }
            public string xpathclick(string xpathclick)
            {
                if (lstXpath.ContainsKey(xpathclick))
                {
                    return lstXpath[xpathclick];
                }
                return null;
            }
            public string xpathtypes(string xpathtypes)
            {
                if (lstXpathtype.ContainsKey(xpathtypes))
                {
                    return lstXpathtype[xpathtypes];
                }
                return null;
            }
            public string parlnkclick(string parlnkclick)
            {
                if (lstParlnk.ContainsKey(parlnkclick))
                {
                    return lstParlnk[parlnkclick];
                }
                return null;
            }
            public string idautofill(string idautofill)
            {
                if (lstIDAutofill.ContainsKey(idautofill))
                {
                    return lstIDAutofill[idautofill];
                }
                return null;
            }
            public string idselbyvalue(string idselbyvalue)
            {
                if (lstIdbyValue.ContainsKey(idselbyvalue))
                {
                    return lstIdbyValue[idselbyvalue];
                }
                return null;
            }
            public string idselbytxt(string idselbytxt)
            {
                if (lstIdbyValue.ContainsKey(idselbytxt))
                {
                    return lstIdbyValue[idselbytxt];
                }
                return null;
            }
            public string hrd_newtab(string hrd_newtab)
            {
                if (lsthrdnewtab.ContainsKey(hrd_newtab))
                {
                    return lsthrdnewtab[hrd_newtab];
                }
                return null;
            }
            public string getemail_gurlla(string getemail_gurlla)
            {
                if (lsgetmailgurilla.ContainsKey(getemail_gurlla))
                {
                    return lsgetmailgurilla[getemail_gurlla];
                }
                return null;
            }
            public string idtxtpaste(string idtxtpaste)
            {
                if (lidtxtpaste.ContainsKey(idtxtpaste))
                {
                    return lidtxtpaste[idtxtpaste];
                }
                return null;
            }
            public string hrd_switch(string hrd_switch)
            {
                if (lswtichto.ContainsKey(hrd_switch))
                {
                    return lswtichto[hrd_switch];
                }
                return null;
            }
            public string datetime(string datetime)
            {
                if (lstDateTime.ContainsKey(datetime))
                {
                    return lstDateTime[datetime];
                }
                return null;
            }
            public string verifydata(string verifydata)
            {
                if (lsverifytxt.ContainsKey(verifydata))
                {
                    return lsverifytxt[verifydata];
                }
                return null;
            }
            /////////////////////////Data////////////////////////////     
            public string idtypedata(string idtypedata)
            {
                if (lddata.ContainsKey(idtypedata))
                {
                    return lddata[idtypedata];
                }
                return null;
            }
            public string iddatabyvalue(string iddatabyvalue)
            {
                if (lddatabyValue.ContainsKey(iddatabyvalue))
                {
                    return lddatabyValue[iddatabyvalue];
                }
                return null;
            }
            public string iddatabytxt(string iddatabytxt)
            {
                if (lddatabyValue.ContainsKey(iddatabytxt))
                {
                    return lddatabyValue[iddatabytxt];
                }
                return null;
            }
            public string idautodata(string idautodata)
            {
                if (ldautofilldata.ContainsKey(idautodata))
                {
                    return ldautofilldata[idautodata];
                }
                return null;
            }
            private static void LoadNavigationList()
            {
                lstNavigate.Add("google_url", "https://www.google.com");
                lstNavigate.Add("usprod_questurl", "https://www.quest.com/");
                lstNavigate.Add("brprod_questurl", "https://www.quest.com/br-pt/");
                lstNavigate.Add("chprod_questurl", "https://www.quest.com/cn-zh/");
                lstNavigate.Add("frprod_questurl", "https://www.quest.com/fr-fr/");
                lstNavigate.Add("grprod_questurl", "https://www.quest.com/de-de/");
                lstNavigate.Add("jpprod_questurl", "https://www.quest.com/jp-ja/");
                lstNavigate.Add("mxprod_questurl", "https://www.quest.com/mx-es/");
                //Quest URLs
                lstNavigate.Add("brquestprod_url", "https://www.quest.com/br-pt/");

                //SonicWall Site
                lstNavigate.Add("sonicwall_prod_url", "https://www.sonicwall.com/");
                lstNavigate.Add("sonicwall_prod_br_url", "https://www.sonicwall.com/br-pt/");
                lstNavigate.Add("sonic_trial_prod_url", "https://www.sonicwall.com/trials/#");
                lstNavigate.Add("sonic_trial_prod_br_url", "https://www.sonicwall.com/br-pt/trials/#");
                lstNavigate.Add("sonicwall_prod_ch_url", "https://www.sonicwall.com/cn-zh");
                lstNavigate.Add("sonic_trial_prod_ch_url", "https://www.sonicwall.com/cn-zh/trials/#");
                lstNavigate.Add("sonicwall_prod_fr_url", "https://www.sonicwall.com/fr-fr/");
                lstNavigate.Add("sonic_trial_prod_fr_url", "https://www.sonicwall.com/fr-fr/trials/#");
                lstNavigate.Add("sonicwall_prod_gr_url", "https://www.sonicwall.com/de-de/");
                lstNavigate.Add("sonic_trial_prod_gr_url", "https://www.sonicwall.com/de-de/trials/#");
                lstNavigate.Add("sonicwall_prod_jp_url", "https://www.sonicwall.com/jp-ja/");
                lstNavigate.Add("sonic_trial_prod_jp_url", "https://www.sonicwall.com/jp-ja/trials/#");
                lstNavigate.Add("sonicwall_prod_mx_url", "https://www.sonicwall.com/mx-es/");
                lstNavigate.Add("sonic_trial_prod_mx_url", "https://www.sonicwall.com/mx-es/trials/#");


                lstNavigate.Add("prodprev_url", "http://software-dell-com/");
                lstNavigate.Add("stage_url", "http://stage.software.dell.com/");
                lstNavigate.Add("usstageprev_url", "http://stage-software-dell-com/");
                lstNavigate.Add("brstageprev_url", "http://stage-software-dell-com/br-pt/");
                lstNavigate.Add("chstageprev_url", "http://stage-software-dell-com/cn-zh/");
                lstNavigate.Add("frstageprev_url", "http://stage-software-dell-com/fr-fr/");
                lstNavigate.Add("destageprev_url", "http://stage-software-dell-com/de-de/");
                lstNavigate.Add("jpstageprev_url", "http://stage-software-dell-com/jp-ja/");
                lstNavigate.Add("mxstageprev_url", "http://stage-software-delothercrtac_btnl-com/mx-es/");
                lstNavigate.Add("stageo2_url", "http://stage-o2.prod.quest.corp/");
                lstNavigate.Add("stageo2landing_url", "http://stage-o2.prod.quest.corp/LandingPages/default.aspx");
            }
            private static void LoadClickNameList()
            {

                lstClick.Add("regsub_btn", "btnSave");
                lstClick.Add("regsubmit_btn", "registersubmit");

                lstClick.Add("othersign_btn", "lnkmainloggin");
                lstClick.Add("updateemail_btn", "btnContinueUpdateEmail");
                lstClick.Add("othercrtac_btn", "CreateAccount");

                lstClick.Add("chklicense_box", "chklicense");
                lstClick.Add("cde_banner", "cde-banner-text");
                lstClick.Add("logout_otherloc", "lnkmainloggOut");
                lstClick.Add("crawled_submit", "Crawledregistersubmit");
                lstClick.Add("gmail_next", "next");
                lstClick.Add("gmail_signinbtn", "signIn");

                /////O2////////

                lstClick.Add("add_btn", "ctl00_ContentPlaceHolder1_ctl00_btn_Add");
                lstClick.Add("saveprvw_btn", "ctl00_ContentPlaceHolder1_ctl00_btn_SaveOnStaging");
                lstClick.Add("img_chk", "ctl00_ContentPlaceHolder1_ctl00_cbxImage");
                lstClick.Add("chooseimg_btn", "chooseImage");
                lstClick.Add("lpgbanner_txt", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_LPG_Banner_Text");
                lstClick.Add("lpgtabtsr_txt", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_LPG_Banner_Text_Tab_Teaser");
                lstClick.Add("lpgvelocity_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_LPG_Velocity_Text_Tab_Teaser");
                lstClick.Add("lpgvideo_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_LPG_Video_Text_Form");
                lstClick.Add("lpgvideortxt_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_LPG_Video_Text_Right_Text");
                lstClick.Add("lpgtxtcol_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_LPG_Text_Column");
                lstClick.Add("lpgcol_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_LPG_Inbound");
                lstClick.Add("blanktam_btn", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_Blank_Template");
                lstClick.Add("tab_chk", "ctl00_ContentPlaceHolder1_ctl00_cbxTabs");
                lstClick.Add("stretch_chk", "ctl00_ContentPlaceHolder1_ctl00_cbxStretchContent");
                lstClick.Add("share_chk", "ctl00_ContentPlaceHolder1_ctl00_cbxShareThisPage");
                lstClick.Add("lpgbnrform_txt", "ctl00_ContentPlaceHolder1_ctl00_rbTemplate_LPG_Banner_Text_Form");
                lstClick.Add("img_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rblImageOrBanners_1");
                lstClick.Add("regasst_btn", "searchregistrationassets");
                lstClick.Add("regassttwo_btn", "searchregistrationassets2");
                lstClick.Add("select_btn", "AssetCodeSearch_Select");
                lstClick.Add("ooyala_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rblVideoType_1");
                lstClick.Add("playlist_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rblSingleOrPlaylist_1");
                lstClick.Add("displayformat_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rblDisplayFormat_1");
                lstClick.Add("addrows_btn", "ctl00_ContentPlaceHolder1_ctl00_btnAddRows");
                lstClick.Add("contsave_btn", "ctl00_ContentPlaceHolder1_ctl00_btnSaveRows");
                lstClick.Add("shimgrit_rbtn", "ctl00_ContentPlaceHolder1_ctl00_rblShowImage2_1");
                lstClick.Add("newevnt_btn", "btn_AddEvent");
                lstClick.Add("fileupload_btn", "btnUploadFile");
                lstClick.Add("webex_rbtn", "SingleEventForm_EvenType_WebEx");
                lstClick.Add("eventasstcode_txt", "SingleEventAssetCode");
                lstClick.Add("eventattendcode_txt", "SingleEventAttendAssetCode");
                lstClick.Add("eventacticcode_btn", "SingleEventSearchTacticCode");
                lstClick.Add("eventcompaignlookup_txt", "CampaignControl_PopUp_Show");
                lstClick.Add("eventcompsave_btn", "CampaignControl_submit");
                lstClick.Add("eventgencode_btn", "btn_GenCode");
                lstClick.Add("eventsave_btn", "btnSubmit");
                lstClick.Add("addsinglesave_btn", "btnSingleEventSave");
                lstClick.Add("webexsave_btn", "btnSaveWebEx");
                lstClick.Add("o2save_btn", "btn_Save");
                lstClick.Add("search_btn", "btn_Search");
                lstClick.Add("archive_btn", "btn_Archive");

            }
            private static void LoadTypeNameList()
            {
                lstType.Add("email_sign_txt", "UserName");
                lstType.Add("confirm_gmail_txt", "UserName2");
                lstType.Add("pwd_sign_txt", "Password");
                lstType.Add("regfname_txt", "FirstName");
                lstType.Add("reglname_txt", "LastName");
                lstType.Add("regphn_txt", "Phone");
                lstType.Add("newpwd_txt", "NewPassword");
                lstType.Add("conpwd_txt", "NewPassword2");
                lstType.Add("sign_mail", "txtuseremail");
                lstType.Add("sign_pwd", "txtpassword");
                lstType.Add("emailid_txt", "Email");
                lstType.Add("emailpwd_txt", "Passwd");
                lstType.Add("changepwd_txt", "TempPassword");
                lstType.Add("chngnewpwd_txt", "NewPassword");
                lstType.Add("chngconfpwd_txt", "NewPassword2");
                lstType.Add("comments_txt", "Comments");
                lstType.Add("company_txt", "Company");


                ////O2////////
                lstType.Add("enddate_txt", "ctl00_ContentPlaceHolder1_ctl00_OasisDateTimePicker2_dateTextBox");
                lstType.Add("title_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxTitle");
                lstType.Add("subtitle_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxSubtitle");
                lstType.Add("btnone_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxButtonText1");
                lstType.Add("cbtnone_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxRowsColumn1ButtonText1");
                lstType.Add("ctowbtnone_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxRowsColumn2ButtonText1");
                lstType.Add("header_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxHeaderScript");
                lstType.Add("tagscript_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxTagScriptBodyTop");
                lstType.Add("tagbtm_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxTagScriptBodyBottom");
                lstType.Add("imgalt_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxImageAltText");
                lstType.Add("tabone_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxTabTitle1");
                lstType.Add("btnvalue_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxButtonValue");
                lstType.Add("playlistid_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxPlaylist");
                lstType.Add("headerone_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxRowsColumn1Header");
                lstType.Add("headertwo_txt", "ctl00_ContentPlaceHolder1_ctl00_tbxRowsColumn2Header");
                lstType.Add("tcode_txt", "tbxTacticCodeSearch");
                lstType.Add("blankbdy_txt", "ctl00_ContentPlaceHolder1_ctl00_htbx_Content");
                lstType.Add("evntinfotip_txt", "InfoToolTip");
                lstType.Add("evntauther", "Author");
                lstType.Add("evntdesciptionsales_txt", "AssetCode_InternalDescription");
                lstType.Add("internalcost_txt", "Cost");
                lstType.Add("eventstart_txt", "SingleEventTime");
                lstType.Add("eventend_txt", "SingleEventEndTime");
                lstType.Add("eventminutes_txt", "SingleEventDuration");
                lstType.Add("eventintrnaldes_txt", "SingleEventInternalDescription");
                lstType.Add("eventmaxreg_txt", "SingleEventMaxRegistrations");
                lstType.Add("eventcompaname_txt", "CampaignControl_CampaignName");
                lstType.Add("search_txt", "SearchKeyword");


            }
            private static void LoadXpathClickList()
            {
                lstXpath.Add("createaccount_lnk", "//*[@id='signin-container']/div/div/div/div[1]/button[2]");
                lstXpath.Add("signout_lnk", "//*[@id='lnkmainloggOut']");
                lstXpath.Add("signIn_sbtn", "//*[@id='LogIn']");

                lstXpath.Add("signbtn_lnk", "//*[@id='signin-link']/span/i");
                lstXpath.Add("signin_btn", "//*[@id='signin-container']/div/div/div/div[1]/button[1]");
                lstXpath.Add("logout_btn", "//*[@id='lnkmainloggOut']");
                lstXpath.Add("forgot_lnk", "//div[3]/a");
                lstXpath.Add("mailurls_lnk", "//td[3]/span");
                lstXpath.Add("myaccount_lnk", "//*[@id='lnkMyAccount']");
                lstXpath.Add("edit_information", "//div[2]/a");
                lstXpath.Add("edit_email", "//a[3]");
                lstXpath.Add("upmail_lnk", "//a[2]");
                lstXpath.Add("gmail_txt_click", "//span[contains(text(),'reset')]");
                lstXpath.Add("gmail_txt_click_br", "//span[contains(text(),'sua')]");
                lstXpath.Add("gmail_txt_click_china", "//span[contains(text(),'应您的要求我们已将您的密')]");
                lstXpath.Add("gmail_txt_click_france", "//span[contains(text(),'Suite')]");
                lstXpath.Add("gmail_txt_click_germany", "//span[contains(text(),'Auf')]");
                lstXpath.Add("gmail_txt_click_japan", "//span[contains(text(),'お客様の要求によ')]");
                lstXpath.Add("gmail_txt_click_mexico", "//span[contains(text(),'Como')]");
                lstXpath.Add("gmail_delete", "//div[@id=':5']/div/div/div/div[2]/div[3]/div/div");
                lstXpath.Add("gmail_profile", "//div[@id='gb']/div/div/div[2]/div[4]/div/a/span");
                lstXpath.Add("mailurl_lnk", "//td[3]/span");
                lstXpath.Add("gmail_more_lnk", "//span[2]/div");
                lstXpath.Add("gmail_spam_lnk", "//a[contains(text(),'Spam (1)')]");
                lstXpath.Add("gmail_notspam", "//td[4]/div[2]/img");
                lstXpath.Add("gmail_inbox_clk", "//div[2]/div/div/div[2]/div/div/div/div/div/div/div/div");

                // Quest
                lstXpath.Add("qsignbtn_lnk", "//*[@id='signin-link']/span/i");
                // submit button click
                lstXpath.Add("br_regsubmit_btn", "//div[12]/div[2]/input");
                //SonicWall
                lstXpath.Add("son_product", "//*[@id='products']/span");
                lstXpath.Add("request_price", "//*[@id='body-container']/article/div[4]/a");
                lstXpath.Add("contact_sales", "//*[@id='frmRegister']/div/div/div[17]/div[2]/input");
                lstXpath.Add("request_price_othr", "//*[@id='body-container']/article/div[4]/a[2]");
                lstXpath.Add("try_online_othr", "//*[@id='body-container']/article/div[4]/a[1]");
                lstXpath.Add("try_online", "//*[@id='body-container']/article/div[1]/div/div[2]/div[2]/a");
                lstXpath.Add("s_analyzer", "//*[@id='S']/div/div[1]/div/a[2]");
                lstXpath.Add("s_document", "//*[@id='footer']/div[1]/ul/li[2]/ul/li[2]/a");
                lstXpath.Add("s_event", "//*[@id='footer']/div[1]/ul/li[2]/ul/li[3]/a");
                lstXpath.Add("sproduct_lnk", "//*[@id='products']/span");
                lstXpath.Add("ssolution_lnk", "//*[@id='masthead']/nav/div[2]/div[2]/ul/li[2]/a/span");
                lstXpath.Add("strial_lnk", "//*[@id='masthead']/nav/div[2]/div[2]/ul/li[3]/a");
                lstXpath.Add("sresurce_lnk", "//*[@id='masthead']/nav/div[2]/div[2]/ul/li[4]/a/span");
                lstXpath.Add("ssuport_lnk", "//*[@id='masthead']/nav/div[2]/div[2]/ul/li[5]/a");
                lstXpath.Add("sblog_lnk", "//*[@id='masthead']/nav/div[2]/div[2]/ul/li[6]/a");
                lstXpath.Add("spartner_lnk", "//*[@id='masthead']/nav/div[2]/div[2]/ul/li[7]/a");
                lstXpath.Add("showtobuy_lnk", "//*[@id='masthead']/nav/div[2]/div[2]/ul/li[8]/a");
                lstXpath.Add("scompany", "//*[@id='footer']/div[1]/ul/li[1]/ul/li[1]/a");
                lstXpath.Add("scontact_us", "//*[@id='footer']/div[1]/ul/li[1]/ul/li[2]/a");
                lstXpath.Add("scareer_us", "//*[@id='footer']/div[1]/ul/li[1]/ul/li[3]/a");
                lstXpath.Add("snews", "//*[@id='footer']/div[1]/ul/li[1]/ul/li[4]/a");
                lstXpath.Add("sfeedback", "//*[@id='footer']/div[1]/ul/li[1]/ul/li[5]/a");
                lstXpath.Add("sblog", "//*[@id='footer']/div[1]/ul/li[2]/ul/li[1]/a");
                lstXpath.Add("sdocument", "//*[@id='footer']/div[1]/ul/li[2]/ul/li[2]/a");
                lstXpath.Add("sevents", "//*[@id='footer']/div[1]/ul/li[2]/ul/li[3]/a");
                lstXpath.Add("svideo", "//*[@id='footer']/div[1]/ul/li[2]/ul/li[4]/a");
                lstXpath.Add("skbase", "//*[@id='footer']/div[1]/ul/li[3]/ul/li[1]/a");
                lstXpath.Add("sservice", "//*[@id='footer']/div[1]/ul/li[3]/ul/li[2]/a");
                lstXpath.Add("smysocinwall", "//*[@id='footer']/div[1]/ul/li[3]/ul/li[3]/a");
                lstXpath.Add("sfacebook", "//*[@id='footer']/div[1]/ul/li[4]/ul/li[1]/a");
                lstXpath.Add("stwitter", "//*[@id='footer']/div[1]/ul/li[4]/ul/li[2]/a");
                lstXpath.Add("slinkedin", "//*[@id='footer']/div[1]/ul/li[4]/ul/li[3]/a");
                lstXpath.Add("spmc", "//*[@id='footer']/div[1]/ul/li[4]/ul/li[4]/a");
                lstXpath.Add("sprivacy", "//*[@id='footer']/div[3]/ul/li[2]/a");
                lstXpath.Add("slegal", "//*[@id='footer']/div[3]/ul/li[3]/a");


                //lstXpath.Add("mailurl_lnk", "//span[contains(text(),'Thank you for your recent')]");
                lstXpath.Add("mailurljp_lnk", "//span[contains(text(),'Dell')]");

                //Header_Link
                lstXpath.Add("dell_logo", "//header[@id='masthead']/nav/div/div/div/a/img");
                lstXpath.Add("products", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li/a");
                lstXpath.Add("view_allproducts", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li/ul/li[11]/a/span");
                lstXpath.Add("ch_view_allproducts", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li/ul/li[2]/a/span");
                lstXpath.Add("jp_view_allproduct", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li/ul/li[6]/a/span");
                lstXpath.Add("solutions", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[2]/a");
                lstXpath.Add("view_allsolutions", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[2]/ul/li[3]/a/span");
                lstXpath.Add("jp_view_allsolution", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[2]/ul/li[6]/a/span");
                lstXpath.Add("trials", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[3]/a");
                lstXpath.Add("buy", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[4]/a");
                lstXpath.Add("support", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[5]/a");
                lstXpath.Add("view_allsupport", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[5]/ul/li[12]/a");
                lstXpath.Add("community", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[6]/a");
                lstXpath.Add("partner", "//header[@id='masthead']/nav/div[2]/div[2]/ul/li[7]/a");

                // Footer Links
                lstXpath.Add("company", "//footer[@id='footer']/div/ul/li/ul/li/a");
                lstXpath.Add("contact_us", "//footer[@id='footer']/div/ul/li/ul/li[2]/a");
                lstXpath.Add("news", "//footer[@id='footer']/div/ul/li/ul/li[3]/a");
                lstXpath.Add("footer_partner", "//footer[@id='footer']/div/ul/li/ul/li[4]/a");
                lstXpath.Add("footer_community", "//footer[@id='footer']/div/ul/li[2]/ul/li/a");
                lstXpath.Add("document", "//footer[@id='footer']/div/ul/li[2]/ul/li[2]/a");
                lstXpath.Add("events", "//footer[@id='footer']/div/ul/li[2]/ul/li[3]/a");
                lstXpath.Add("video", "//footer[@id='footer']/div/ul/li[2]/ul/li[4]/a");
                lstXpath.Add("professional_services", "//footer[@id='footer']/div/ul/li[3]/ul/li/a");
                lstXpath.Add("renewing_support", "//footer[@id='footer']/div/ul/li[3]/ul/li[2]/a");
                lstXpath.Add("technical_support", "//footer[@id='footer']/div/ul/li[3]/ul/li[3]/a");
                lstXpath.Add("training", "//footer[@id='footer']/div/ul/li[3]/ul/li[4]/a");
                lstXpath.Add("facebook", "//footer[@id='footer']/div/ul/li[4]/ul/li/a");
                lstXpath.Add("google", "//footer[@id='footer']/div/ul/li[4]/ul/li[2]/a");
                lstXpath.Add("linkedIn", "//footer[@id='footer']/div/ul/li[4]/ul/li[3]/a");
                lstXpath.Add("twitter", "//footer[@id='footer']/div/ul/li[4]/ul/li[4]/a");
                lstXpath.Add("brazil_terms_cond", "//footer/div[2]/ul/li[2]/a");
                lstXpath.Add("brazil_privacy", "//footer/div[2]/ul/li[3]/a");
                lstXpath.Add("brazil_feedback", "//footer/div[2]/ul/li[4]/a");
                lstXpath.Add("us_terms_cond", "//div[3]/ul/li[2]/a");
                lstXpath.Add("us_privacy", "//div[3]/ul/li[3]/a");
                lstXpath.Add("us_feedback", "//div[3]/ul/li[4]/a");
                // Email template
                lstXpath.Add("email_txt_click", "//div[2]/div/span/a");

                // Products Click
                lstXpath.Add("first_product", "//a/h4");


                // Download Trial click
                lstXpath.Add("download_trial", "//div[2]/div/a");
                lstXpath.Add("jp_download_trial", "//div[4]/a");
                lstXpath.Add("last_trial", "//div[7]/div/div[14]/div/a/h4");
                lstXpath.Add("br_last_trial", "//div[7]/div/div[2]/div/a/h4");
                lstXpath.Add("dtrial_submit", "//div[17]/div[2]/input");
                lstXpath.Add("france_trial_sbtn", "//div[8]/div[2]/input");

                // country select
                lstXpath.Add("contry_slt", "//li[5]/span/span");
                // Documents
                lstXpath.Add("click_alldoc", "//button[@type='button']");
                lstXpath.Add("uncheck_alldoc", "//input[@name='selectAllcontent_type']");
                lstXpath.Add("check_whitepaper", "//li[3]/label/input");
                lstXpath.Add("first_whitepaper", "//div[@id='mainer']/div[3]/section/div/div/a/h4");
                lstXpath.Add("sub_wpepar_btn", "//div[16]/div[2]/input");

                // Events
                lstXpath.Add("uncheck_allevnt", "//input[@name='selectAllevent_type']");
                lstXpath.Add("check_event", "//li[2]/label/input");
                lstXpath.Add("first_event", "//h4");
                lstXpath.Add("selectreg_chk", "//td/input");
                lstXpath.Add("next_btn", "//form/div/div/button");
                lstXpath.Add("attendevent_btn", "//div[11]/div[2]/input");

                lstXpath.Add("mailurlchina_lnk", "//span[contains(text(),'dell')]");
                lstXpath.Add("mailurl_kacelnk", "//span[contains(text(),'Thank')]");
                lstXpath.Add("vtrial_btn", ".//*[@id='products']/tbody[21]/tr[3]/td[3]/a/span");
                lstXpath.Add("usfooterevent_lnk", ".//*[@id='wrapper']/div[3]/footer/div/div[1]/ul/li[2]/ul/li[3]/a");
                lstXpath.Add("otherfooterevent_lnk", ".//*[@id='footer-links']/dl[2]/dd[2]/a");
                lstXpath.Add("fstevent_lnk", ".//*[@id='events']/section/div[2]/div[1]/div/a/h2");

                lstXpath.Add("nextpageevnt_btn", ".//*[@id='form-step-0']/div/input");
                lstXpath.Add("product_tab", "//span[.='Products']");
                lstXpath.Add("cloudmng_menu", "//span[.='Cloud Management']");
                lstXpath.Add("activesysmng_menu", "//a[text()='Active System Manager']");
                lstXpath.Add("compaign_tab", "//a[text()='Campaigns']");
                lstXpath.Add("landpage_smenu", "//a[text()='Landing Pages']");
                lstXpath.Add("product_menu", "//span[.='Products']");
                lstXpath.Add("datapro_smenu", "//span[.='Data Protection']");
                lstXpath.Add("crtnewpwd_btn", "//button[@id='createPass']");
                lstXpath.Add("updatepwd_btn", "//button[@type='submit']");
                lstXpath.Add("sign_btn_click", "//*[@id='signin-button']");
                lstXpath.Add("whitepaper_btn", "//input[@type='submit']");
                lstXpath.Add("event_lnk", "//div[@id='webcasts']/section/div[2]/div/div/a/h2"); ;
                lstXpath.Add("ondemand_tab", "//a[@id='ui-id-2']");

                /////////////////O2/////////////
                lstXpath.Add("select_img", "//*[@id='imageselect']/span");
                lstXpath.Add("move_list", "//input[@value='→']");
                lstXpath.Add("moveright_list", "(//input[@value='→'])[2]");
                lstXpath.Add("search_btns", ".//*[@id='btnSearchSecondaryTacticCode']");
                lstXpath.Add("attendevt_btn", "//*[@id='frmRegister']/div[11]/div/input']");
                lstXpath.Add("evntstarddate_clr", "//*[@id='EditEventTable']/tbody/tr[6]/td[2]/span/span/span/span[1]");
                lstXpath.Add("evntdocudate_clr", "//*[@id='EditDocumentTable']/tbody/tr[22]/td[2]/span[1]/span/span/span");
                lstXpath.Add("evntinternalcost", "//*[@id='tr_InternalCost']/td[2]/span/span/span/span[2]/span");
                lstXpath.Add("evntaddfile", "//*[@id='data_File']/input[2]");
                lstXpath.Add("singleevent_clr", "//*[@id='SingleEventForm']/table/tbody/tr[3]/td[2]/span/span/span/span");
                lstXpath.Add("eventdurminuts", "//*[@id='SingleEventForm']/table/tbody/tr[7]/td[2]/span/span/span/span[2]/span");
                lstXpath.Add("eventmax", "//*[@id='SingleEventForm_MaxRegistrations']/td[2]/span/span/span/span[2]/span");
                lstXpath.Add("productsselector", "//*[@id='EditEventTable']/tbody/tr[33]/td[2]/div[1]/table/tbody/tr[2]/td[2]/input[1]");
                lstXpath.Add("platfarmsselector", "//*[@id='EditEventTable']/tbody/tr[34]/td[2]/table/tbody/tr[2]/td[2]/input[1]");
                lstXpath.Add("solutionssselector", "//*[@id='EditEventTable']/tbody/tr[35]/td[2]/table/tbody/tr[2]/td[2]/input[1]");
                lstXpath.Add("o2save_btns", "(//*[@id='btn_Save'])[2]");
                lstXpath.Add("preview_link", "//*[@id='GridEvents']/table/tbody/tr/td[8]/a/img");
                lstXpath.Add("publishlive_lnk", "//*[@id='GridEvents']/table/tbody/tr/td[7]/a/img");
                lstXpath.Add("editevent_lnk", "//*[@id='GridEvents']/table/tbody/tr/td[1]/a[1]");
                lstXpath.Add("publishlive_btn", "//*[@id='btn_Publish']");
                lstXpath.Add("mailurlevnt_lnk", "//span[contains(text(),'asdf')]");

                ////webex//////
                lstXpath.Add("webextool_close", "//*[@id='dialog-0']/div/div/div[1]/a/span[1]");
                lstXpath.Add("webexsiteevnt_lnk", "//a[@id='wcc-lnk-siteEvents']/span[2]");
                lstXpath.Add("webexlogin_lnk", ".//*[@id='wcc-lnk-loginLink']");
                lstXpath.Add("webexlogon_btn", "//*[@id='mwx-btn-logon']");
                lstXpath.Add("evntcenterwebex_lnk", "//*[@id='wcc-lnk-EC']");
                lstXpath.Add("webexlogout_lnk", "//a[@id='wcc-lnk-logoutLink']");


                /// google

                lstXpath.Add("google_sbtn", "//button");

                // sitecatalyst
                lstXpath.Add("brhproduct", "//div[2]/div/div/ul/li/div/h4/a");

            }
            public string xpathdatatypes(string xpathdatatypes)
            {
                if (xpathdata.ContainsKey(xpathdatatypes))
                {
                    return xpathdata[xpathdatatypes];
                }
                return null;
            }
            private static void LoadXpathTypeList()
            {
                lstXpathtype.Add("iframe_bdy", "//*[@id='body-container']");
                lstXpathtype.Add("iframe_tcode", ".//*[@id='tbxTacticCodeSearch']");
                lstXpathtype.Add("evntiframe_bdy", "//*[@id='EditEventTable']//iframe");
                lstXpathtype.Add("evntwhatulearn_bdy", "//*[@id='EditEventTable']/tbody/tr[18]/td[2]/table/tbody/tr[2]/td/iframe");
                lstXpathtype.Add("evntspeaker_bdy", "//*[@id='EditEventTable']/tbody/tr[19]/td[2]/table/tbody/tr[2]/td/iframe");
                lstXpathtype.Add("evntfilename", "(//input[@id='Name'])[2]");
                lstXpathtype.Add("evntregfullprom_bdy", "//*[@id='tr_RegistrationFullPromote']//iframe");

                ///webex//
                lstXpathtype.Add("username_txt", "//*[@id='mwx-ipt-username']");
                lstXpathtype.Add("userpswd_txt", "//*[@id='mwx-ipt-password']");

                // google com
                lstXpathtype.Add("google_sbox", "//input[@id='lst-ib']");



            }
            private static void LoadCParlnkClickList()
            {
                lstParlnk.Add("mail_link", "https://account.software.dell.com/account/confirm/");
                lstParlnk.Add("qmail_link", "https://account.quest.com/account/confirm/");
                lstParlnk.Add("mailtxt_link", "Dell");
                lstParlnk.Add("stgprmail_link", "//software-dell-com/");
                lstParlnk.Add("signout_lnks", "Sign out");
                lstParlnk.Add("preview_lnk", "Preview");
                lstParlnk.Add("dateyear_lnk", ", 2015");
                lstParlnk.Add("envntsingle_lnk", "Add single");
                lstParlnk.Add("enventwebexsetup_lnk", "WebEx Setup");

                // SonicWall
                lstParlnk.Add("e10800_lnk", "E10800");
                lstParlnk.Add("9800_lnk", "9800");
                lstParlnk.Add("9200_lnk", "9200");
                lstParlnk.Add("e10400_lnk", "E10400");
                lstParlnk.Add("9600_lnk", "9600");
                lstParlnk.Add("e10200_lnk", "E10200");
                lstParlnk.Add("9400_lnk", "9400");
                lstParlnk.Add("3600_lnk", "3600");
                lstParlnk.Add("TZ400_lnk", "TZ400");
                lstParlnk.Add("sonicPoint_lnk", "SonicPoint ACe");
                // sitecatalyst
                lstParlnk.Add("hproduct_lnk", "Endpoint System Management");
                lstParlnk.Add("chproduct_lnk", "数据库管理.");
                lstParlnk.Add("frproduct_lnk", "Gestion des postes clients");
                lstParlnk.Add("grproduct_lnk", "Endpunktverwaltung");
                lstParlnk.Add("jpproduct_lnk", "データベース管理");
                lstParlnk.Add("mxproduct_lnk", "Monitoreo de Performance");
                //google
                lstParlnk.Add("usdell_lnk", "Dell Software Official Site - Simplify IT Management | Mitigate Risk ...");
                lstParlnk.Add("activeadmin_lnk", "Active Administrator - Dell Software");
                lstParlnk.Add("chinadell_lnk", "中国（中文） - Dell Software");
                lstParlnk.Add("japandell_lnk", "デル・ソフトウェア - Dell Software");
            }
            private static void LoadidautofillSelectList()
            {
                lstIDAutofill.Add("sal_company", "Companydb");
                lstIDAutofill.Add("sal_comp", "Company");


            }
            private static void LoadidselbyvalueList()
            {
                lstIdbyValue.Add("salvalue_dd", "Title");
                lstIdbyValue.Add("totalcompvalue_dd", "TotalComputersManaged");
                lstIdbyValue.Add("kacetitle_dd", "KACETitleRoles");
                lstIdbyValue.Add("pubsector_dd", "PublicSector");
                lstIdbyValue.Add("choosetype_dd", "type");
                lstIdbyValue.Add("brand_modelone", "brand-model");
                lstIdbyValue.Add("dell_upgrade", "dell-model");
                lstIdbyValue.Add("brand_two", "brand");
                ///////o2////////////
                lstIdbyValue.Add("product_dd", "ctl00_ContentPlaceHolder1_ctl00_ddlProduct");
                lstIdbyValue.Add("select_listbox", "ctl00_ContentPlaceHolder1_ctl00_dlbBanners_lbx_Availables");
                lstIdbyValue.Add("slctright_listbox", "ctl00_ContentPlaceHolder1_ctl00_dlbRightRailBanners_lbx_Availables");
                lstIdbyValue.Add("slctlead_dd", "ctl00_ContentPlaceHolder1_ctl00_ddlLeadFor");
                lstIdbyValue.Add("slctasset_dd", "ctl00_ContentPlaceHolder1_ctl00_ddlAssetTypes");
                lstIdbyValue.Add("asstcode_lbox", "ctl00_ContentPlaceHolder1_ctl00_lbxAssetCodes");
                lstIdbyValue.Add("formtop_dd", "ctl00_ContentPlaceHolder1_ctl00_ddlFormTopText");
                lstIdbyValue.Add("formbtn_dd", "ctl00_ContentPlaceHolder1_ctl00_ddlFormButtonText");
                lstIdbyValue.Add("sctabtn_dd", "ctl00_ContentPlaceHolder1_ctl00_ddlSecondaryCTAButtonText");
                lstIdbyValue.Add("sctlocalities_dd", "Locality_ItemID");
                lstIdbyValue.Add("evntlanguage_dd", "Language_ID");
                lstIdbyValue.Add("evntcountry_dd", "AssetInfoLocation_ID");
                lstIdbyValue.Add("evntproductlead_dd", "AssetCode_ProductID");
                lstIdbyValue.Add("evntleadfor_dd", "AssetCode_LeadForSiteID");
                lstIdbyValue.Add("evntprimarybuyer_dd", "BuyerStage_AssetMetadata_ID");
                lstIdbyValue.Add("evnttimezone_dd", "SingleEventTimeZone");
                lstIdbyValue.Add("evntstate_dd", "SingleEventState");
                lstIdbyValue.Add("evntcountrybuyer_dd", "SingleEventCountryBuyerStage");
                lstIdbyValue.Add("evntteam_dd", "MarketingTeam_ID");
                lstIdbyValue.Add("evntcbo_dd", "CBOSegment_ID");
                lstIdbyValue.Add("evntprogram_dd", "Program");
                lstIdbyValue.Add("evntprogramtype_dd", "ProgramType");
                lstIdbyValue.Add("evntprogramsubtype_dd", "ProgramSubType");
                lstIdbyValue.Add("evntsltyear_dd", "ddlYear");
                lstIdbyValue.Add("evntquarter_dd", "ddlQuarter");
                lstIdbyValue.Add("evntregion_dd", "ddlDellRegion");
                lstIdbyValue.Add("evntwebexhost_dd", "Data_Host_ID");

                lstIdbyValue.Add("products_dd", "lbxProductsAvailable");
                lstIdbyValue.Add("platfarm_dd", "lbxPlatformsAvailable");
                lstIdbyValue.Add("solutions_dd", "lbxSolutionsAvailable");
                lstIdbyValue.Add("searchlocality_dd", "SearchLocality");

            }
            private static void LoadidselbytxtList()
            {

                ///////o2////////////



            }
            private static void LoadhrdnewtabList()
            {
                lsthrdnewtab.Add("guerrilla_url", "https://www.guerrillamail.com/");
                lsthrdnewtab.Add("webextext_url", "https://dellsoftwaretest.webex.com/");
            }
            private static void LoadGetmaillist()
            {
                lsgetmailgurilla.Add("gur_mailbyid", "email-widget");

            }
            private static void Loadidtxtpastelist()
            {
                lidtxtpaste.Add("regemail_txt", "Emaildb");
                lidtxtpaste.Add("kaceregemail_txt", "Email");
                lidtxtpaste.Add("updateemail_txt", "updateemailnewemail");
                lidtxtpaste.Add("confirmeemail_txt", "txtconfirmemail");
            }
            private static void LoadChrd_switchList()
            {
                lswtichto.Add("mail", "guerrillamail");
                // lswtichto.Add("application", "software.dell");
                lswtichto.Add("productss", "products");
                lswtichto.Add("trialsts", "trials");
                lswtichto.Add("buynew", "buy");
                lswtichto.Add("supportt", "support");
                lswtichto.Add("partners", "partners");
                lswtichto.Add("application", "software");
                lswtichto.Add("qapplication", "quest");
                lswtichto.Add("dellsite", "www.dell.com");
                lswtichto.Add("sonicwall", "sonicwall");
                ////O2////////
                lswtichto.Add("oaisis", "prod");

                //homePage header
                lswtichto.Add("community_tab", "community");



                //Footer links
                lswtichto.Add("news_tab", "newsroom");
                lswtichto.Add("profesional_tab", "professional");
                lswtichto.Add("renewing_tab", "renewing");
                lswtichto.Add("technical_support_tab", "support");
                lswtichto.Add("training_tab", "training");
                lswtichto.Add("facebook_tab", "facebook");
                lswtichto.Add("google_tab", "google");
                lswtichto.Add("linkedin_tab", "linkedin");
                lswtichto.Add("twitter_tab", "twitter");
                //sonicwall
                lswtichto.Add("scareer_tab", "/careers.aspx");
                lswtichto.Add("sblog_tab", "blog.");
                lswtichto.Add("skbas_tab", "kb-product-select");
                lswtichto.Add("sservice_tab", "support-offerings");
                lswtichto.Add("smysonic_tab", "/login.aspx");
                lswtichto.Add("slegal_tab", "/legal/");
                lswtichto.Add("s_application", "https://www.sonicwall.com");
                ///webex///
                lswtichto.Add("webex", "webex.com/");

            }
            private static void Loaddatetimelist()
            {
                lstDateTime.Add("timeid", "ctl00_ContentPlaceHolder1_ctl00_tbxInternalName");
                lstDateTime.Add("evntLocdatetime_txt", "DisplayName");
                lstDateTime.Add("eventassetcode_txt", "AssetCode");

            }
            /////////////////////////Data////////////////////////////
            private static void iddatatype()
            {
                lddata.Add("email_id", "3tyxaf+9bx1n94g1u1cc@sharklasers.com");
                lddata.Add("gmail_id", "softwaredelltesting@gmail.com");
                lddata.Add("gmail_pwd", "mukesh123");
                lddata.Add("pwd", "mukesh123@");
                lddata.Add("fname", "Mukesh");
                lddata.Add("lname", "Jha");
                lddata.Add("fnameupdate", "Suresh");
                lddata.Add("lnameupdate", "Jha");
                lddata.Add("phone", "1234567890");
                lddata.Add("newpwd", "mukesh123@");
                lddata.Add("confpwd", "mukesh123@");
                lddata.Add("chgpwd", "mukesh123@");
                lddata.Add("chgnewpwd", "mukesh@1234");
                lddata.Add("chngconfpwd", "mukesh@1234");
                lddata.Add("email", "mukesh.jha@software.dell.com");
                lddata.Add("comments", "This is the testing comments to test the comments fields");
                lddata.Add("companyname", "TestTestTest");
                lddata.Add("license_chk", ".//*[@id='tr_PrivacyPolicy']/td/table/tbody/tr/td/div/input");//need to change

                ///////////O2////////////
                lddata.Add("endofcuryear", "Dec 31, 2015");
                lddata.Add("titletxt", "This is title");
                lddata.Add("subtitletxt", "This is sub title");
                lddata.Add("btnonetxt", "ButtonOne");
                lddata.Add("cbtnonetxt", "ConButtonOne");
                lddata.Add("ctwobtnonetxt", "ConTwoButtonOne");
                lddata.Add("headertxt", "This is header script text");
                lddata.Add("tagtxt", "This is tag script text");
                lddata.Add("tagbtmtxt", "This is tag bottom script text");
                lddata.Add("imgalttxt", "This is image alt text");
                lddata.Add("tabtxt", "This is tabone");
                lddata.Add("btnvaluetxt", "Test Button");
                lddata.Add("playlistdata", "This is playlist text");
                lddata.Add("header_data", "This is row header text");
                lddata.Add("headertwo_data", "This is row headertwo text");
                lddata.Add("blankbdy_data", "This is row blank body text");
                lddata.Add("eventtip_data", "This is event info tool tip data");
                lddata.Add("eventauther_data", "This is event auther data");
                lddata.Add("eventdescrsales_data", "This is event description data");
                lddata.Add("evntinternalcost", "20");
                lddata.Add("evntstarttime", "11:00 PM");
                lddata.Add("evntendtime", "11:30 PM");
                lddata.Add("evntduration", "30");
                lddata.Add("evntdescription", "Internal Description");
                lddata.Add("evntmaxreg", "30");
                lddata.Add("evntcompaignname", "vRanger");


            }
            private static void xpathdatatype()
            {

                ///////////O2////////////
                xpathdata.Add("bodytxt", "This is body txt");
                xpathdata.Add("lowbodytxt", "This is lower body txt");
                xpathdata.Add("tabonebodytxt", "This is tab one body txt");
                xpathdata.Add("headertxt", "This is form header txt");
                xpathdata.Add("screenshottxt", "This is screen shot text");
                xpathdata.Add("contenttxt", "This is content data text");
                xpathdata.Add("contenttwotxt", "This is contenttwo data text");
                xpathdata.Add("landingtxt", "This is landing txt data text");
                xpathdata.Add("lbenifitstxt", "This is landing page benifits data text");
                xpathdata.Add("thankstxt", "This is thank you data text");
                xpathdata.Add("sctattxt", "This is secondry CTA data text");
                xpathdata.Add("sctadtxt", "This is secondry CTA description data text");
                xpathdata.Add("sctadaddtxt", "This is secondry CTA additional promote data text");
                xpathdata.Add("tsearch_data", "23");
                xpathdata.Add("eventwhatulearn", "Event what you will learn");
                xpathdata.Add("eventspeaker", "Event speaker data");
                xpathdata.Add("eventregprom", "Registration Full Promote");

                ////webex///
                xpathdata.Add("username", "mjha");
                xpathdata.Add("userpswd", "questsw1");

                // google search
                xpathdata.Add("search_for_us", "dell software");
                xpathdata.Add("search_for_brazil", "dell software brazil");
                xpathdata.Add("search_for_china", "dell software china");
                xpathdata.Add("search_for_france", "dell software france");
                xpathdata.Add("search_for_germany", "dell software germany");
                xpathdata.Add("search_for_japan", "dell software japan");
                xpathdata.Add("search_for_mexico", "dell software mexico");
                xpathdata.Add("search_for_activeadmin", "active administrator dell software");
            }
            private static void selectbyvalue()
            {
                lddatabyValue.Add("value", "29");
                lddatabyValue.Add("totalcompvalue", "25 - 99");
                lddatabyValue.Add("kacetitlevalue", "IT - Help Desk");
                lddatabyValue.Add("pubsectvalue", "Commercial");
                lddatabyValue.Add("typevalueone", "Firewall");
                lddatabyValue.Add("brandvalueone", "TZ 100 Series");
                lddatabyValue.Add("dellupvalue", "TZ300 Series");
                lddatabyValue.Add("typevaluetwo", "SRA");
                lddatabyValue.Add("brandvaluetwo", "Barracuda");
                lddatabyValue.Add("brandvaluethree", "280");
                lddatabyValue.Add("dellupvaluetwo", "SRA 1600");


                ///////o2////////////
                lddatabyValue.Add("productvalue", "681");
                lddatabyValue.Add("productvalueone", "780");
                lddatabyValue.Add("selectlisttxt", "58181");
                lddatabyValue.Add("selectrighttxt", "58158");
                lddatabyValue.Add("slctleadfor", "7");
                lddatabyValue.Add("slctasst", "8");
                lddatabyValue.Add("asstcode", "55119");
                lddatabyValue.Add("formtop", "TAFAttendEvent");
                lddatabyValue.Add("forbtn", "BtnAttendEvent");
                lddatabyValue.Add("evnteng", "53");
                lddatabyValue.Add("evntcountry", "4");
                lddatabyValue.Add("evntprductlead", "897");
                lddatabyValue.Add("evntlead", "1");
                lddatabyValue.Add("evntprimarybuyer", "3");
                lddatabyValue.Add("evnttimezone", "PST");
                lddatabyValue.Add("state", "AK");
                lddatabyValue.Add("eventbuyer", "3");
                lddatabyValue.Add("evntteam", "1");
                lddatabyValue.Add("evntcbo", "1");
                lddatabyValue.Add("evntprogrm", "Customer Marketing");
                lddatabyValue.Add("evntprogrmtype", "Customer Acquisition");
                lddatabyValue.Add("evntprogrmsubtype", "Online Events");
                lddatabyValue.Add("evntsltyear", "2015");
                lddatabyValue.Add("evntqtr", "Q3");
                lddatabyValue.Add("evntregion", "All");
                lddatabyValue.Add("evntwebexhost", "mjha");
                lddatabyValue.Add("productsss", "691");
                lddatabyValue.Add("platfarm", "69");
                lddatabyValue.Add("solutionst", "54");
                lddatabyValue.Add("uslocalities", "3");
                lddatabyValue.Add("brazillocalities", "58603");
                lddatabyValue.Add("chinalocalities", "59536");
                lddatabyValue.Add("francelocalities", "59538");
                lddatabyValue.Add("germanylocalities", "59539");
                lddatabyValue.Add("japanlocalities", "59537");
                lddatabyValue.Add("mexicolocalities", "58589");
                lddatabyValue.Add("searchlocalitydata", "All Localities");
                lddatabyValue.Add("brazillocalitydata", "58603");
                lddatabyValue.Add("chinalocalitydata", "59536");
                lddatabyValue.Add("germanylocalitydata", "59539");
                lddatabyValue.Add("francelocalitydata", "59538");
                lddatabyValue.Add("japanlocalitydata", "59537");
                lddatabyValue.Add("mexicolocalitydata", "58589");
            }
            private static void selectbytxt()
            {
                ///////o2////////////


            }
            private static void autofilldata()
            {
                ldautofilldata.Add("com_name", "Dell International Services");


            }
            private static void Loadverifytxtlist()
            {
                lsverifytxt.Add("sign_btn", "btnLogging");
                lsverifytxt.Add("copyright_txt", "©2015");
                lsverifytxt.Add("logo", "/images/shared/logo.png");
                lsverifytxt.Add("search", "Search");
                lsverifytxt.Add("username", "Mukesh Jha");
                lsverifytxt.Add("email_text_exist", "FirstName");

                ///////////O2////////////
                lsverifytxt.Add("bodytxt", "This is body txt");
                lsverifytxt.Add("titletxt", "This is title");
                lsverifytxt.Add("subtitletxt", "This is sub title");
                lsverifytxt.Add("btnonetxt", "ButtonOne");
                lsverifytxt.Add("imgalttxt", "This is image alt text");
                lsverifytxt.Add("lpgbanner", "Case Study");
                lsverifytxt.Add("sharepage", "Share This Page");
                lsverifytxt.Add("tabonebodytxt", "This is tab one body txt");
                lsverifytxt.Add("screenshottxt", "This is screen shot text");
                lsverifytxt.Add("tagbtmtxt", "This is tag bottom script text");
                lsverifytxt.Add("headertxt", "This is header script text");
                lsverifytxt.Add("contenttxt", "This is content data text");
                lsverifytxt.Add("contenttwotxt", "This is contenttwo data text");
                lsverifytxt.Add("cbtnonetxt", "ConButtonOne");
                lsverifytxt.Add("ctwobtnonetxt", "ConTwoButtonOne");
                lsverifytxt.Add("blankbdy_data", "This is row blank body text");
                lsverifytxt.Add("eventwhatulearn", "Event what you will learn");
                lsverifytxt.Add("eventspeaker", "Event speaker data");
                lsverifytxt.Add("meetingendtime", "11:30 PM PST");
                lsverifytxt.Add("meetingtime", "11:00 PM, Pacific Standard");


            }
        }
    
}
