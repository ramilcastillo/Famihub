using NHibernate.Criterion;
using System;
using System.IO;
using System.Reflection;

namespace FamiHub.Common
{
    internal class Install
    {
        static int currentDbV = 3;
        private static void UpdateProcessor(string dbV)
        {
            if (dbV == "0") GenerateBaseData();
            if (dbV == "1") GenerateCountryData();
            if (dbV == "2") GenerateUserMenuBaseData();
            if (dbV == "3") GenerateBecosoftLinkCustomersProperty();
        }
        public static void UpdateDb()
        {
            try
            {
                Models.Core.Property pV = Crud.GetById<Models.Core.Property, string>("pgmInstalledVersion");
                if (pV == null)
                {
                    pV = new Models.Core.Property();
                    pV.Key = "pgmInstalledVersion";
                    pV.Value = "";
                }

                if (pV.Value != Assembly.GetExecutingAssembly().GetName().Version.ToString() || System.Diagnostics.Debugger.IsAttached)
                {
                    InstallProgramDefinition();
                    pV.Value = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    Crud.Put(pV);
                }

                Models.Core.Property dbV = Crud.GetById<Models.Core.Property, string>("dbInstalledDataVersion");
                if (dbV == null)
                {
                    dbV = new Models.Core.Property();
                    dbV.Key = "dbInstalledDataVersion";
                    dbV.Value = "-1";
                }

                if (Convert.ToInt16(dbV.Value) < currentDbV)
                {
                    dbV.Value = (Convert.ToInt16(dbV.Value) + 1).ToString();
                    UpdateProcessor(dbV.Value);
                    Crud.Put(dbV);
                    UpdateDb();
                }
            }
            catch (Exception ex)
            {
                Common.ExceptionHandling.HandleException(ex);
            }
        }
        private static void GenerateBaseData()
        {
            Models.Core.UserGroup adminUserGroup = new Models.Core.UserGroup();
            adminUserGroup.Name = "Default";
            Crud.Put(adminUserGroup);

            Models.Core.User adminUser = new Models.Core.User();
            adminUser.Active = true;
            adminUser.FirstName = "Administrator";
            adminUser.Language = "en";
            adminUser.UserName = "admin";
            adminUser.Password = Encryption.Encrypt.EncryptText("admin");
            adminUser.UserGroup = adminUserGroup;
            Crud.Put(adminUser);
        }
        private static void GenerateUserMenuBaseData()
        {
            var session = Session.DatabaseConnection;
            Models.Core.User user = session.CreateCriteria(typeof(Models.Core.User))
                            .Add(Expression.Eq("UserName", "admin"))
                            .Add(Expression.Eq("Active", true))
                            .UniqueResult<Models.Core.User>();

            Models.Core.Menu menu = new Models.Core.Menu();
            menu.Description = "Default";
            Crud.Put(menu);

            Models.Core.UserGroup ug = user.UserGroup;
            Models.Core.UserGroupMenu ugMenu = new Models.Core.UserGroupMenu();
            ugMenu.UserGroup = ug;
            ugMenu.Menu = menu;
            ugMenu.Sequence = 10;
            Crud.Put(ugMenu);

            Models.Core.MenuItem menuItem = new Models.Core.MenuItem();
            menuItem.Sequence = 10;
            menuItem.Menu = menu;
            menuItem.Program = Crud.GetById<Models.Core.Program, string>("FHCore.MenuForm");
            Crud.Put(menuItem);
        }
        private static void AddCountry(string isoCode, string name)
        {
            Models.Core.Country country = new Models.Core.Country();
            country.IsoCode = isoCode;
            country.Name = name;
            Crud.Put(country);
        }
        private static void GenerateCountryData()
        {
            AddCountry("AF", "Afghanistan");
            AddCountry("AL", "Albania");
            AddCountry("DZ", "Algeria");
            AddCountry("AS", "American Samoa");
            AddCountry("AD", "Andorra");
            AddCountry("AO", "Angola");
            AddCountry("AI", "Anguilla");
            AddCountry("AQ", "Antarctica");
            AddCountry("AG", "Antigua and Barbuda");
            AddCountry("AR", "Argentina");
            AddCountry("AM", "Armenia");
            AddCountry("AW", "Aruba");
            AddCountry("AU", "Australia");
            AddCountry("AT", "Austria");
            AddCountry("AZ", "Azerbaijan");
            AddCountry("BS", "Bahamas");
            AddCountry("BH", "Bahrain");
            AddCountry("BD", "Bangladesh");
            AddCountry("BB", "Barbados");
            AddCountry("BY", "Belarus");
            AddCountry("BE", "Belgium");
            AddCountry("BZ", "Belize");
            AddCountry("BJ", "Benin");
            AddCountry("BM", "Bermuda");
            AddCountry("BT", "Bhutan");
            AddCountry("BO", "Bolivia");
            AddCountry("BA", "Bosnia and Herzegovina");
            AddCountry("BW", "Botswana");
            AddCountry("BV", "Bouvet Island");
            AddCountry("BR", "Brazil");
            AddCountry("BQ", "British Antarctic Territory");
            AddCountry("IO", "British Indian Ocean Territory");
            AddCountry("VG", "British Virgin Islands");
            AddCountry("BN", "Brunei");
            AddCountry("BG", "Bulgaria");
            AddCountry("BF", "Burkina Faso");
            AddCountry("BI", "Burundi");
            AddCountry("KH", "Cambodia");
            AddCountry("CM", "Cameroon");
            AddCountry("CA", "Canada");
            AddCountry("CT", "Canton and Enderbury Islands");
            AddCountry("CV", "Cape Verde");
            AddCountry("KY", "Cayman Islands");
            AddCountry("CF", "Central African Republic");
            AddCountry("TD", "Chad");
            AddCountry("CL", "Chile");
            AddCountry("CN", "China");
            AddCountry("CX", "Christmas Island");
            AddCountry("CC", "Cocos [Keeling] Islands");
            AddCountry("CO", "Colombia");
            AddCountry("KM", "Comoros");
            AddCountry("CG", "Congo - Brazzaville");
            AddCountry("CD", "Congo - Kinshasa");
            AddCountry("CK", "Cook Islands");
            AddCountry("CR", "Costa Rica");
            AddCountry("HR", "Croatia");
            AddCountry("CU", "Cuba");
            AddCountry("CY", "Cyprus");
            AddCountry("CZ", "Czech Republic");
            AddCountry("CI", "Côte d’Ivoire");
            AddCountry("DK", "Denmark");
            AddCountry("DJ", "Djibouti");
            AddCountry("DM", "Dominica");
            AddCountry("DO", "Dominican Republic");
            AddCountry("NQ", "Dronning Maud Land");
            AddCountry("DD", "East Germany");
            AddCountry("EC", "Ecuador");
            AddCountry("EG", "Egypt");
            AddCountry("SV", "El Salvador");
            AddCountry("GQ", "Equatorial Guinea");
            AddCountry("ER", "Eritrea");
            AddCountry("EE", "Estonia");
            AddCountry("ET", "Ethiopia");
            AddCountry("FK", "Falkland Islands");
            AddCountry("FO", "Faroe Islands");
            AddCountry("FJ", "Fiji");
            AddCountry("FI", "Finland");
            AddCountry("FR", "France");
            AddCountry("GF", "French Guiana");
            AddCountry("PF", "French Polynesia");
            AddCountry("TF", "French Southern Territories");
            AddCountry("FQ", "French Southern and Antarctic Territories");
            AddCountry("GA", "Gabon");
            AddCountry("GM", "Gambia");
            AddCountry("GE", "Georgia");
            AddCountry("DE", "Germany");
            AddCountry("GH", "Ghana");
            AddCountry("GI", "Gibraltar");
            AddCountry("GR", "Greece");
            AddCountry("GL", "Greenland");
            AddCountry("GD", "Grenada");
            AddCountry("GP", "Guadeloupe");
            AddCountry("GU", "Guam");
            AddCountry("GT", "Guatemala");
            AddCountry("GG", "Guernsey");
            AddCountry("GN", "Guinea");
            AddCountry("GW", "Guinea-Bissau");
            AddCountry("GY", "Guyana");
            AddCountry("HT", "Haiti");
            AddCountry("HM", "Heard Island and McDonald Islands");
            AddCountry("HN", "Honduras");
            AddCountry("HK", "Hong Kong SAR China");
            AddCountry("HU", "Hungary");
            AddCountry("IS", "Iceland");
            AddCountry("IN", "India");
            AddCountry("ID", "Indonesia");
            AddCountry("IR", "Iran");
            AddCountry("IQ", "Iraq");
            AddCountry("IE", "Ireland");
            AddCountry("IM", "Isle of Man");
            AddCountry("IL", "Israel");
            AddCountry("IT", "Italy");
            AddCountry("JM", "Jamaica");
            AddCountry("JP", "Japan");
            AddCountry("JE", "Jersey");
            AddCountry("JT", "Johnston Island");
            AddCountry("JO", "Jordan");
            AddCountry("KZ", "Kazakhstan");
            AddCountry("KE", "Kenya");
            AddCountry("KI", "Kiribati");
            AddCountry("KW", "Kuwait");
            AddCountry("KG", "Kyrgyzstan");
            AddCountry("LA", "Laos");
            AddCountry("LV", "Latvia");
            AddCountry("LB", "Lebanon");
            AddCountry("LS", "Lesotho");
            AddCountry("LR", "Liberia");
            AddCountry("LY", "Libya");
            AddCountry("LI", "Liechtenstein");
            AddCountry("LT", "Lithuania");
            AddCountry("LU", "Luxembourg");
            AddCountry("MO", "Macau SAR China");
            AddCountry("MK", "Macedonia");
            AddCountry("MG", "Madagascar");
            AddCountry("MW", "Malawi");
            AddCountry("MY", "Malaysia");
            AddCountry("MV", "Maldives");
            AddCountry("ML", "Mali");
            AddCountry("MT", "Malta");
            AddCountry("MH", "Marshall Islands");
            AddCountry("MQ", "Martinique");
            AddCountry("MR", "Mauritania");
            AddCountry("MU", "Mauritius");
            AddCountry("YT", "Mayotte");
            AddCountry("FX", "Metropolitan France");
            AddCountry("MX", "Mexico");
            AddCountry("FM", "Micronesia");
            AddCountry("MI", "Midway Islands");
            AddCountry("MD", "Moldova");
            AddCountry("MC", "Monaco");
            AddCountry("MN", "Mongolia");
            AddCountry("ME", "Montenegro");
            AddCountry("MS", "Montserrat");
            AddCountry("MA", "Morocco");
            AddCountry("MZ", "Mozambique");
            AddCountry("MM", "Myanmar [Burma]");
            AddCountry("NA", "Namibia");
            AddCountry("NR", "Nauru");
            AddCountry("NP", "Nepal");
            AddCountry("NL", "Netherlands");
            AddCountry("AN", "Netherlands Antilles");
            AddCountry("NT", "Neutral Zone");
            AddCountry("NC", "New Caledonia");
            AddCountry("NZ", "New Zealand");
            AddCountry("NI", "Nicaragua");
            AddCountry("NE", "Niger");
            AddCountry("NG", "Nigeria");
            AddCountry("NU", "Niue");
            AddCountry("NF", "Norfolk Island");
            AddCountry("KP", "North Korea");
            AddCountry("VD", "North Vietnam");
            AddCountry("MP", "Northern Mariana Islands");
            AddCountry("NO", "Norway");
            AddCountry("OM", "Oman");
            AddCountry("PC", "Pacific Islands Trust Territory");
            AddCountry("PK", "Pakistan");
            AddCountry("PW", "Palau");
            AddCountry("PS", "Palestinian Territories");
            AddCountry("PA", "Panama");
            AddCountry("PZ", "Panama Canal Zone");
            AddCountry("PG", "Papua New Guinea");
            AddCountry("PY", "Paraguay");
            AddCountry("YD", "People's Democratic Republic of Yemen");
            AddCountry("PE", "Peru");
            AddCountry("PH", "Philippines");
            AddCountry("PN", "Pitcairn Islands");
            AddCountry("PL", "Poland");
            AddCountry("PT", "Portugal");
            AddCountry("PR", "Puerto Rico");
            AddCountry("QA", "Qatar");
            AddCountry("RO", "Romania");
            AddCountry("RU", "Russia");
            AddCountry("RW", "Rwanda");
            AddCountry("RE", "Réunion");
            AddCountry("BL", "Saint Barthélemy");
            AddCountry("SH", "Saint Helena");
            AddCountry("KN", "Saint Kitts and Nevis");
            AddCountry("LC", "Saint Lucia");
            AddCountry("MF", "Saint Martin");
            AddCountry("PM", "Saint Pierre and Miquelon");
            AddCountry("VC", "Saint Vincent and the Grenadines");
            AddCountry("WS", "Samoa");
            AddCountry("SM", "San Marino");
            AddCountry("SA", "Saudi Arabia");
            AddCountry("SN", "Senegal");
            AddCountry("RS", "Serbia");
            AddCountry("CS", "Serbia and Montenegro");
            AddCountry("SC", "Seychelles");
            AddCountry("SL", "Sierra Leone");
            AddCountry("SG", "Singapore");
            AddCountry("SK", "Slovakia");
            AddCountry("SI", "Slovenia");
            AddCountry("SB", "Solomon Islands");
            AddCountry("SO", "Somalia");
            AddCountry("ZA", "South Africa");
            AddCountry("GS", "South Georgia and the South Sandwich Islands");
            AddCountry("KR", "South Korea");
            AddCountry("ES", "Spain");
            AddCountry("LK", "Sri Lanka");
            AddCountry("SD", "Sudan");
            AddCountry("SR", "Suriname");
            AddCountry("SJ", "Svalbard and Jan Mayen");
            AddCountry("SZ", "Swaziland");
            AddCountry("SE", "Sweden");
            AddCountry("CH", "Switzerland");
            AddCountry("SY", "Syria");
            AddCountry("ST", "São Tomé and Príncipe");
            AddCountry("TW", "Taiwan");
            AddCountry("TJ", "Tajikistan");
            AddCountry("TZ", "Tanzania");
            AddCountry("TH", "Thailand");
            AddCountry("TL", "Timor-Leste");
            AddCountry("TG", "Togo");
            AddCountry("TK", "Tokelau");
            AddCountry("TO", "Tonga");
            AddCountry("TT", "Trinidad and Tobago");
            AddCountry("TN", "Tunisia");
            AddCountry("TR", "Turkey");
            AddCountry("TM", "Turkmenistan");
            AddCountry("TC", "Turks and Caicos Islands");
            AddCountry("TV", "Tuvalu");
            AddCountry("UM", "U.S. Minor Outlying Islands");
            AddCountry("PU", "U.S. Miscellaneous Pacific Islands");
            AddCountry("VI", "U.S. Virgin Islands");
            AddCountry("UG", "Uganda");
            AddCountry("UA", "Ukraine");
            AddCountry("SU", "Union of Soviet Socialist Republics");
            AddCountry("AE", "United Arab Emirates");
            AddCountry("GB", "United Kingdom");
            AddCountry("US", "United States");
            AddCountry("ZZ", "Unknown or Invalid Region");
            AddCountry("UY", "Uruguay");
            AddCountry("UZ", "Uzbekistan");
            AddCountry("VU", "Vanuatu");
            AddCountry("VA", "Vatican City");
            AddCountry("VE", "Venezuela");
            AddCountry("VN", "Vietnam");
            AddCountry("WK", "Wake Island");
            AddCountry("WF", "Wallis and Futuna");
            AddCountry("EH", "Western Sahara");
            AddCountry("YE", "Yemen");
            AddCountry("ZM", "Zambia");
            AddCountry("ZW", "Zimbabwe");
            AddCountry("AX", "Åland Islands");
        }
        private static void GenerateBecosoftLinkCustomersProperty()
        {
            Models.Core.Property property = new Models.Core.Property();
            property.Key = "Becosoft:CustomerLinkActive";
            property.Value = "0";
            Crud.Put(property);
        }
        private static void InstallProgramDefinition()
        {
            BusinessLayer.General.Logging.Log("Updating program table in database", BusinessLayer.General.Logging.LogLevel.Info);

            string data;
            Models.Core.Module packObj = null;
            Stream pgmFile = Assembly.GetExecutingAssembly().GetManifestResourceStream("FamiHub.UI.Programs.txt");
            using (StreamReader reader = new StreamReader(pgmFile))
            {
                while (reader.Peek() >= 0)
                {
                    data = reader.ReadLine();

                    if (!string.IsNullOrEmpty(data))
                    {
                        BusinessLayer.General.Logging.Log(". Processing line: " + data.ToString(), BusinessLayer.General.Logging.LogLevel.Debug);
                        if (data.ToString().Substring(0, 2) != "''")
                        {
                            if (data.ToString().Substring(0, 1) == "*" &&
                                data.ToString().Substring(data.ToString().Length - 1, 1) == "*")
                            {
                                string[] packArray = data.Split(new char[] { '\\' });
                                string package = packArray[0].Trim('*');

                                BusinessLayer.General.Logging.Log(".. Processing line for module: '" + package + "'", BusinessLayer.General.Logging.LogLevel.Debug);
                                if (!string.IsNullOrEmpty(package?.Trim()))
                                {
                                    string packageDescr = "";

                                    try
                                    {
                                        packageDescr = packArray[1].Trim('*');
                                    }
                                    catch
                                    {
                                        BusinessLayer.General.Logging.Log("... Cannot determine module description for '" + package + "'", BusinessLayer.General.Logging.LogLevel.Warning);
                                    }

                                    if (packageDescr.Trim() == "") packageDescr = package;

                                    Models.Core.Module pack = Crud.GetById<Models.Core.Module, string>(package);
                                    if (pack == null)
                                    {
                                        BusinessLayer.General.Logging.Log("... Module doesn't exist, creating new module '" + package + "'", BusinessLayer.General.Logging.LogLevel.Debug);
                                        pack = new Models.Core.Module();
                                        pack.Package = package;
                                    }

                                    BusinessLayer.General.Logging.Log("... Saving module '" + package + "'", BusinessLayer.General.Logging.LogLevel.Info);
                                    pack.Description = packageDescr;
                                    Crud.Put(pack);
                                    packObj = pack;
                                }
                                else
                                {
                                    BusinessLayer.General.Logging.Log(".. Found corrupt module definition, line skipped", BusinessLayer.General.Logging.LogLevel.Warning);
                                    package = null;
                                    packObj = null;
                                }
                            }
                            else
                            {
                                BusinessLayer.General.Logging.Log(".. Processing line for program: " + data.ToString(), BusinessLayer.General.Logging.LogLevel.Debug);
                                string[] array = data.Split(new char[] { '\\' });
                                string desc = array[0];
                                string type = array[1];
                                string code = array[2];
                                string form = array[3];

                                Models.Core.Program prog = Crud.GetById<Models.Core.Program, string>(form);
                                if (prog != null)
                                {
                                    BusinessLayer.General.Logging.Log("... Saving program '" + form + "'", BusinessLayer.General.Logging.LogLevel.Debug);
                                    prog.Code = code;
                                    prog.Description = desc;
                                    prog.Form = form;
                                    prog.Type = type;
                                    prog.Package = packObj;
                                }
                                else
                                {
                                    BusinessLayer.General.Logging.Log("... Program doesn't exist, creating new program '" + form + "'", BusinessLayer.General.Logging.LogLevel.Debug);
                                    prog = new Models.Core.Program()
                                    {
                                        Code = code,
                                        Description = desc,
                                        Form = form,
                                        Type = type,
                                        Package = packObj
                                    };
                                }

                                Crud.Put(prog);
                            }
                        }
                        else
                        {
                            BusinessLayer.General.Logging.Log(".. Skipping line because this is a comment", BusinessLayer.General.Logging.LogLevel.Debug);
                        }
                    }
                }
            }

            BusinessLayer.General.Logging.Log("Updated program table in database", BusinessLayer.General.Logging.LogLevel.Info);
        }
    }
}