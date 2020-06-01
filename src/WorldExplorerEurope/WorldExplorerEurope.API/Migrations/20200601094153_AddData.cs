using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldExplorerEurope.API.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Flag = table.Column<string>(nullable: true),
                    Population = table.Column<long>(nullable: false),
                    Capital = table.Column<string>(nullable: true),
                    Currency = table.Column<string>(nullable: true),
                    IsEUMember = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountrySpotifyPlaylist",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CountryId = table.Column<Guid>(nullable: false),
                    PlaylistId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountrySpotifyPlaylist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    IsSpotifyDj = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryFavourites",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(nullable: false),
                    FavouriteId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryFavourites", x => new { x.CountryId, x.FavouriteId });
                    table.ForeignKey(
                        name: "FK_CountryFavourites_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryFavourites_Favourites_FavouriteId",
                        column: x => x.FavouriteId,
                        principalTable: "Favourites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryPhotoMemories",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(nullable: false),
                    MemoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryPhotoMemories", x => new { x.CountryId, x.MemoryId });
                    table.ForeignKey(
                        name: "FK_CountryPhotoMemories_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryPhotoMemories_Memories_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryWishlists",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(nullable: false),
                    WishlistId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryWishlists", x => new { x.CountryId, x.WishlistId });
                    table.ForeignKey(
                        name: "FK_CountryWishlists_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryWishlists_Wishlists_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Currency", "Description", "Flag", "IsEUMember", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("e9c2bbb2-0b7c-4797-b718-1d6427ce5b56"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("e36904a8-db72-4609-878e-fe9522818fd8"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("cb3e023b-8ff3-42d1-b9f6-003b1c56c7fb"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("eee9345e-d565-483e-a9b9-cfa3e6ed390f"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("77f6cc30-0e95-4a69-9b39-e2bd7d3e3555"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("2c5c52a2-1a41-4441-b723-2e6b62d82c1d"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("5453cd1c-285b-4bb4-ba45-36910cc27553"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("297e015e-0f79-449d-9d76-8d8acdbfa250"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("22a9a13c-9dc3-43a3-89cb-74cba3e60196"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("117d9002-3139-46b3-8ad3-6645232683df"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("5bb1e76b-37b7-4fd2-85d4-bf8dbc05d896"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("e435c84f-3cb7-413d-b736-5583f88d5e34"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("8515b177-cefa-4b97-941a-cbefecfdb8e4"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("5c25b26c-a450-4b5a-87aa-ed69fa12a519"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("794e53cf-c177-4add-9059-29d2bf940471"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("c1243176-94aa-4dcb-b491-bf76b42a51c8"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("d81cbd31-faf6-4319-b5c9-f1d353a31a3d"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("96a70518-ba88-49e5-8f7a-de84a4e05d97"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("7c8578ae-ab6b-4146-80ab-a2a0ed13d4c7"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("036e06bb-0acc-4c3b-8dc2-1a3f09b2ec79"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("b4c43988-9f48-4f6d-9677-81dbb798445a"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("9fd16fd1-df8c-492b-ae8a-abcc709a666e"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("c9d38955-eecb-4abd-ac09-11d94cb12cfc"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("f6f9a324-0ec7-4678-8140-146285862ce6"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("10a2c21a-1c50-4070-8b4f-ea8b8c6498b9"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("64b3bacf-9b06-4aba-a8c7-daa1fd377e57"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("63d3a7c4-1805-45a1-8672-6a8f1b20fbb1"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("31c2cde1-460a-4574-adee-feaa8aceda5d"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("6fc08fcd-453f-4540-b99f-ed15df4cbda6"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("2e510cdb-9a30-48dc-ac29-1fb87c050570"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("a5799345-1831-4495-b197-5fa258da3d99"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("f87fe66d-9370-4e51-9133-9cdfbd28285c"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("217f2421-d119-4981-9368-405500c61307"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("c297a878-3c3e-4ce8-b106-f5d13a773fb8"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("f9866052-b409-4854-8df8-5cc2a5df00bf"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("7f91cf40-63d3-472d-bdcf-c55a3198442f"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("517bd5c6-2a07-4741-9ff2-41b9670646ac"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("7b5e2d61-7509-4382-a0b7-7e871208596d"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("f4c63455-fcd4-4f20-aa72-baecad92bcc1"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("054d6ccf-586d-4aea-b708-53dbdb79cd66"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("0e82d29f-be64-4310-86eb-798c30ecd97e"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("fce34303-a45b-4d05-aa99-b1a6bad21fef"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("34167427-e3eb-4e81-a205-79069ebf88db"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("68a7a4d9-b315-46af-b32c-a9459544c3d5"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("731d9fc3-150b-454e-832c-a10eb7434ca5"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("0cb1242b-089c-41a3-b15c-1f8af80a9ad2"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("1904d334-4556-4226-96fd-e46b43df57cc"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("6a924c84-b14e-49ea-b09b-3d3d68acd9df"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("76e047c9-a180-48da-aefd-500e35f3cb50"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("089a1f12-e600-4221-a7ac-9a99bfa81839"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("c827d792-6cb9-4900-a20a-626ef20290f7"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("325de8bd-c041-438b-a365-00975fcb6a0f"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("a66ac9bf-2e15-470d-bf46-4649443c1da7"), new Guid("eee9345e-d565-483e-a9b9-cfa3e6ed390f"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("6800f9a1-b957-4704-a0cf-9a5fafa4cd1c"), new Guid("2c5c52a2-1a41-4441-b723-2e6b62d82c1d"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("f648f6a1-e4a5-4855-8ca3-af6a647d03ad"), new Guid("5c25b26c-a450-4b5a-87aa-ed69fa12a519"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("443270a9-9dc9-4806-883d-910dd5cace43"), new Guid("5453cd1c-285b-4bb4-ba45-36910cc27553"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("96f83c81-9d23-483c-818b-14397af8b287"), new Guid("297e015e-0f79-449d-9d76-8d8acdbfa250"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("9fe84c4b-4f07-489e-8b10-bbd8678212b1"), new Guid("22a9a13c-9dc3-43a3-89cb-74cba3e60196"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("1f73fedf-f34b-4030-9a83-c0545090eeee"), new Guid("117d9002-3139-46b3-8ad3-6645232683df"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("330825f4-af50-45a3-9c97-2a171b415571"), new Guid("5bb1e76b-37b7-4fd2-85d4-bf8dbc05d896"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("82ec3424-6c81-48e3-a823-cdcdc4cd6c3a"), new Guid("e435c84f-3cb7-413d-b736-5583f88d5e34"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("b8de6e99-59d6-4ce5-869f-d73287aef54f"), new Guid("8515b177-cefa-4b97-941a-cbefecfdb8e4"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("07ccfa70-ffc9-4c4a-afac-ea6e8cf6ef31"), new Guid("036e06bb-0acc-4c3b-8dc2-1a3f09b2ec79"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("9e86e36c-5148-490e-a91f-7b934018ef6f"), new Guid("c1243176-94aa-4dcb-b491-bf76b42a51c8"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("ce47a31a-7f15-4371-9301-121b6b744b2f"), new Guid("d81cbd31-faf6-4319-b5c9-f1d353a31a3d"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("6db7b6bd-380d-4c70-acc6-350e9ecc4c08"), new Guid("96a70518-ba88-49e5-8f7a-de84a4e05d97"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("b6868806-be02-437c-bbe1-8000c50d9472"), new Guid("b4c43988-9f48-4f6d-9677-81dbb798445a"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("b339852f-335c-4212-9a01-730bf5f6eb25"), new Guid("64b3bacf-9b06-4aba-a8c7-daa1fd377e57"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("6a28582a-56d4-4668-b6db-cfbda302e8fc"), new Guid("9fd16fd1-df8c-492b-ae8a-abcc709a666e"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("f579dae2-c627-41ea-9310-bac9491a40aa"), new Guid("c9d38955-eecb-4abd-ac09-11d94cb12cfc"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("73c1a94c-0e77-489d-8e34-fa849ee14a60"), new Guid("cb3e023b-8ff3-42d1-b9f6-003b1c56c7fb"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("205d2728-e096-4d05-9d0f-8550a77484f6"), new Guid("00000000-0000-0000-0000-000000000001"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("6733a41d-9c08-40f5-bd88-e07d83d64c15"), new Guid("794e53cf-c177-4add-9059-29d2bf940471"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("b61efd94-0d53-408e-b258-e9eb9a7819c4"), new Guid("e36904a8-db72-4609-878e-fe9522818fd8"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("e67ab3bb-949d-4048-babd-cd7691adab86"), new Guid("7b5e2d61-7509-4382-a0b7-7e871208596d"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("25b62a9c-624f-42a8-88bc-1d609ef11e15"), new Guid("325de8bd-c041-438b-a365-00975fcb6a0f"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("b429f90d-97a1-415c-bf65-75a673f391eb"), new Guid("e9c2bbb2-0b7c-4797-b718-1d6427ce5b56"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("5da35445-e373-4409-9632-d3b0fce59cfe"), new Guid("6fc08fcd-453f-4540-b99f-ed15df4cbda6"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("44c0d7a4-115f-48cc-8241-66e47a81ab9d"), new Guid("054d6ccf-586d-4aea-b708-53dbdb79cd66"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("27ab59d4-70ff-480b-b3a5-e8edf323e7b5"), new Guid("a5799345-1831-4495-b197-5fa258da3d99"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("65cdbe06-91b7-4c73-a193-a0d603e031e6"), new Guid("f87fe66d-9370-4e51-9133-9cdfbd28285c"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("12425a7c-c42f-4b6f-af1b-a77178b7903d"), new Guid("c297a878-3c3e-4ce8-b106-f5d13a773fb8"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("59ddd6ce-8a6f-4b1b-b8a6-058b974127b6"), new Guid("f9866052-b409-4854-8df8-5cc2a5df00bf"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("f5ab6a2e-e06a-4f8c-94de-38e0cd227242"), new Guid("7f91cf40-63d3-472d-bdcf-c55a3198442f"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("57a53fde-cfd5-4a68-a427-c85b60360ecc"), new Guid("63d3a7c4-1805-45a1-8672-6a8f1b20fbb1"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("84ed50d6-a325-480c-a6d3-127ba292ba7a"), new Guid("517bd5c6-2a07-4741-9ff2-41b9670646ac"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("0ef8f081-da2d-45ca-b973-47338563e633"), new Guid("fce34303-a45b-4d05-aa99-b1a6bad21fef"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("79f8efc9-c2d1-4ab8-a9ab-7e1e6f729cde"), new Guid("0e82d29f-be64-4310-86eb-798c30ecd97e"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("cb132a1e-9fa7-429a-a8f1-26dde3ceb44d"), new Guid("089a1f12-e600-4221-a7ac-9a99bfa81839"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("70b192b0-af68-4c09-9a99-918c8180a0b0"), new Guid("76e047c9-a180-48da-aefd-500e35f3cb50"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("fca2a095-b66e-4412-9e5f-9c462bd238a1"), new Guid("6a924c84-b14e-49ea-b09b-3d3d68acd9df"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("60a30f33-bd6d-4a88-aa11-6c86ccf00092"), new Guid("1904d334-4556-4226-96fd-e46b43df57cc"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("53ee72d8-d37c-421a-9a54-f07000d4906e"), new Guid("68a7a4d9-b315-46af-b32c-a9459544c3d5"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("32565213-8cd7-4b7b-9c7e-97b718b5c023"), new Guid("0cb1242b-089c-41a3-b15c-1f8af80a9ad2"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("5a102ac9-d94c-4b77-ac89-a17b8ff9d6b5"), new Guid("34167427-e3eb-4e81-a205-79069ebf88db"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("b90b8eae-cb4e-47ee-8cb0-891c2509b2f0"), new Guid("f4c63455-fcd4-4f20-aa72-baecad92bcc1"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsSpotifyDj", "LastName", "LockoutEnabled", "LockoutEnd", "Nationality", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a5311214-564f-4824-ba65-b57042349e49", 0, new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "dc93944d-4f21-4391-817c-dcccf6e16cf4", "gaspard.lammertyn@student.howest.be", false, "Gaspard", false, "Lammertyn", false, null, "Belgium", null, null, "AQAAAAEAACcQAAAAEBrBhFVfJGw+U7ktJ4LEuZlYxs3QztZogmHsCotrD14gVJomt4jOkf0X/FgPb7qZcw==", null, false, "Admin", "de6accff-4118-4fd9-bb4e-37a9e1f16f97", false, null },
                    { "00000000-0000-0000-0000-000000000001", 0, new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "abf257c1-fdfd-4ce4-9beb-f6f4a78de73a", "test.test@student.howest.be", false, "test", true, "test", false, null, "Belgium", null, null, "AQAAAAEAACcQAAAAEM2b+IJ3kSRqBBifFLbUQ588WnBPOVzxRcPTKXvK9Zlmlxk/LqzEq9sPVksCsmRA+w==", null, false, "Admin", "7fe584da-7e2b-459d-aa99-c4cdc4231573", false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryFavourites_FavouriteId",
                table: "CountryFavourites",
                column: "FavouriteId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryPhotoMemories_MemoryId",
                table: "CountryPhotoMemories",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryWishlists_WishlistId",
                table: "CountryWishlists",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CountryFavourites");

            migrationBuilder.DropTable(
                name: "CountryPhotoMemories");

            migrationBuilder.DropTable(
                name: "CountrySpotifyPlaylist");

            migrationBuilder.DropTable(
                name: "CountryWishlists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Wishlists");
        }
    }
}
