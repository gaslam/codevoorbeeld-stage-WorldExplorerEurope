using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldExplorerEurope.API.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
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
                    { new Guid("8fe115b9-360f-4df6-b8f7-8bd4c49ea1ee"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("d640db4c-bbfc-4928-bdff-5dfba3c6fd07"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("ae827744-35f9-417c-baf4-b6e02efe4ab6"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("54e64111-13d2-45ba-ad77-4ac1f7e3a320"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("5098d9d9-bcda-4a66-8739-e1d88c12f900"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("85e293e6-ffd0-46de-8585-528aae9169ae"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("2c6c7f55-e265-4725-8087-9bfb847d962d"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("c58aff06-1005-4fb5-b3e4-30355ef50631"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("29ec73fa-bf32-4ec2-8bc9-4e7e26ae428c"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("45c2c8d2-7eda-42b2-bc15-3d2b36431818"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("8cceb0fb-5625-4374-a7b0-273006e75566"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("b9bbcb74-886f-416e-9fcd-cb2a970dc401"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("e12d8999-f19b-4b13-9919-8aea6e5e7727"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("d1563279-28bd-441a-b6ba-91004ffad1c1"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("bdc55d46-d804-4288-9b28-9ea74af86ecc"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("03a47008-3792-424f-8fd3-36a25c199e3c"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("a2375522-afc6-49f4-8570-35460e8fc408"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("8a8ca4e2-8de0-41a4-ac73-a8050620b89c"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("cebc1ac2-c95b-449f-b678-7dcd716216e9"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("2aaac76b-5fa3-4157-a431-9db62b6a0684"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("aa034507-1f43-46dd-a229-2b90c476b317"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("0ac6211d-6e58-40a8-a95d-927aff66c9c7"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("0c2f9008-b7e6-43ef-a779-7c59693534da"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("984d52de-bdfb-49d3-bff8-5a1bb18f55a4"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("070be2c1-1eff-490b-9628-b82b0912ce30"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("fe2d8c19-37f7-43e0-880b-1919ccbf8f31"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("36923dba-fbe8-44b8-a3ef-7ac452e2b0ef"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("357126f6-9845-4ee0-968a-f82389ca3f22"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("137397e5-8ea9-4ec9-b9fe-11bbb5385f69"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("b82094f1-9389-49f4-a3e5-45739ae8c28a"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("add96a0e-9872-42f5-8d3b-06ed45e15b22"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("3f1b518f-70f9-4093-a767-56f49abb817d"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("d56accff-95ca-4223-b67e-98fbc67a805a"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("bf360d98-6684-404d-a89d-d748a2104a76"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("17fc9ef3-39db-41d0-8199-57d67f7828be"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("df6a4a81-8adc-4857-a0b9-a0bf144b1b18"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("a4a0cff7-c494-4057-ab81-8d01bb65f0b5"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("bd9d15d0-b603-434a-b789-fdcbea3f5cb1"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("75b10934-b789-4015-bf30-f43c7e2ce9fa"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("0c26f670-b553-4829-9393-21be39b85aee"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("387e1a76-8297-4ca6-956a-f2a96d40d519"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("aa1a95bf-de4c-494b-b9f1-13e3be67d448"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("5689ba6d-6dce-4238-bf3a-605798f05b92"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("8a626148-97c2-4e68-a944-2dddd3d40838"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("5995de9e-ea6a-4807-8a28-e1eb9f0275d1"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("a93edb85-31e7-4688-82b2-03c4035e59fb"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("55cdbef1-7ec4-4a46-9a4c-477f10d39b40"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("be1239fd-0285-4ca2-b33f-25882a5ccbb9"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("21c0b6fc-fb68-4541-95b4-ca9598271f27"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("5f81cea5-29df-40a0-9157-7dfc18867222"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("7c60ceee-8144-458b-b502-8cf9152d9183"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("a495d284-4859-49d4-829e-31ef5364ef8c"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("cbccf11d-22c3-4bd7-9694-3211e63c10a3"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("875bdb77-bfb4-4d64-aa4e-cd8d3b5a3610"), new Guid("54e64111-13d2-45ba-ad77-4ac1f7e3a320"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("b8d70805-f2cb-4bfc-94b1-471845537b69"), new Guid("85e293e6-ffd0-46de-8585-528aae9169ae"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("34e7e261-14cf-4338-8b05-43a29324bcff"), new Guid("e12d8999-f19b-4b13-9919-8aea6e5e7727"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("969ce445-d81f-48a9-a1e2-1e5a738d321d"), new Guid("2c6c7f55-e265-4725-8087-9bfb847d962d"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("85761e85-9f07-4061-b043-cb789286e30f"), new Guid("c58aff06-1005-4fb5-b3e4-30355ef50631"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("552233aa-c28c-4408-b050-ef14a3a03a13"), new Guid("29ec73fa-bf32-4ec2-8bc9-4e7e26ae428c"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("9b86e6e3-4c13-4280-9d12-4d525bf7277e"), new Guid("45c2c8d2-7eda-42b2-bc15-3d2b36431818"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("c48649e1-a7d9-4429-9dde-e7287205ca61"), new Guid("8cceb0fb-5625-4374-a7b0-273006e75566"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("3bb6224b-0be5-4556-806d-ae8688920a1f"), new Guid("b9bbcb74-886f-416e-9fcd-cb2a970dc401"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("6297da60-87b3-4dc3-a281-c4f3817ebe3b"), new Guid("8a8ca4e2-8de0-41a4-ac73-a8050620b89c"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("fe257441-7cbb-445c-9562-43767cd8ae61"), new Guid("bdc55d46-d804-4288-9b28-9ea74af86ecc"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("9837748d-9bcf-48e4-b892-cbb3cf89e0d9"), new Guid("03a47008-3792-424f-8fd3-36a25c199e3c"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("7c837dd8-b677-496e-9276-29122de48ffb"), new Guid("a2375522-afc6-49f4-8570-35460e8fc408"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("12bc666a-27ac-415b-b9a9-e80a4d6f0bc3"), new Guid("2aaac76b-5fa3-4157-a431-9db62b6a0684"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("49709ab1-a012-4787-a7c7-502bf57ad165"), new Guid("36923dba-fbe8-44b8-a3ef-7ac452e2b0ef"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("95acd403-9dfe-4ce1-83a9-dad2685736dc"), new Guid("aa034507-1f43-46dd-a229-2b90c476b317"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("8dadb3ac-6973-4758-ae44-a19aaac48798"), new Guid("0ac6211d-6e58-40a8-a95d-927aff66c9c7"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("b8371232-edfe-4459-aaff-1477c7ed36cd"), new Guid("ae827744-35f9-417c-baf4-b6e02efe4ab6"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("3d1f5ea4-274a-4bd2-a204-95bf4458861a"), new Guid("0c2f9008-b7e6-43ef-a779-7c59693534da"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("6bd7cd1e-c675-43d8-8ddc-dd0ea398c059"), new Guid("d1563279-28bd-441a-b6ba-91004ffad1c1"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("c5f353f0-0052-41d5-9dc7-c857ffb831f8"), new Guid("d640db4c-bbfc-4928-bdff-5dfba3c6fd07"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("93304022-5779-4680-8d48-ee153706a66e"), new Guid("75b10934-b789-4015-bf30-f43c7e2ce9fa"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("76390f94-cdb0-4b09-9587-4c56a7fc1d75"), new Guid("cbccf11d-22c3-4bd7-9694-3211e63c10a3"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("e38c7738-9fb0-4335-8bd2-d020abe424f5"), new Guid("984d52de-bdfb-49d3-bff8-5a1bb18f55a4"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("d22882b8-3755-4892-94de-8f39751a4d78"), new Guid("8fe115b9-360f-4df6-b8f7-8bd4c49ea1ee"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("749eb580-3ecf-4b1e-882e-879b7bfc406c"), new Guid("b82094f1-9389-49f4-a3e5-45739ae8c28a"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("d7f55e13-bc6e-4984-bed7-7e446646e3f4"), new Guid("387e1a76-8297-4ca6-956a-f2a96d40d519"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("e9e8f282-4d02-4269-89f5-06fb02a19f8e"), new Guid("3f1b518f-70f9-4093-a767-56f49abb817d"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("cdaaf906-3948-47c7-913b-2ad04ca99605"), new Guid("d56accff-95ca-4223-b67e-98fbc67a805a"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("5590185b-223b-4a01-a231-92da76dc043c"), new Guid("17fc9ef3-39db-41d0-8199-57d67f7828be"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("b8b71d09-9cbf-4385-a5b5-2c547e4cdda0"), new Guid("df6a4a81-8adc-4857-a0b9-a0bf144b1b18"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("2f7a00be-1b50-42d7-bc68-55480fc5f4dd"), new Guid("a4a0cff7-c494-4057-ab81-8d01bb65f0b5"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("b010b172-d1c5-4d19-96fb-ef1088095d77"), new Guid("357126f6-9845-4ee0-968a-f82389ca3f22"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("e0d16b1f-9ac9-437f-a623-fab28d75a72b"), new Guid("bd9d15d0-b603-434a-b789-fdcbea3f5cb1"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("f5688e83-9af6-40ac-94cb-af6c241935bb"), new Guid("5689ba6d-6dce-4238-bf3a-605798f05b92"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("a377ae2a-05a2-46cd-a436-48b26e8e50f9"), new Guid("aa1a95bf-de4c-494b-b9f1-13e3be67d448"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("9628f25c-03c2-4992-b5ab-b4a9501d16a6"), new Guid("7c60ceee-8144-458b-b502-8cf9152d9183"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("7352af0a-42a2-4f05-8973-dc052f5f5559"), new Guid("5f81cea5-29df-40a0-9157-7dfc18867222"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("687fb2d5-1485-4ea3-8f12-f56d07125c93"), new Guid("21c0b6fc-fb68-4541-95b4-ca9598271f27"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("5c039b09-2174-4b25-b0e1-d24db5024b52"), new Guid("be1239fd-0285-4ca2-b33f-25882a5ccbb9"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("5e37c11f-2d41-45c2-970d-4b3c36279a64"), new Guid("5995de9e-ea6a-4807-8a28-e1eb9f0275d1"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("15f003c2-ff3f-49e9-8c17-a6089cc9c17c"), new Guid("55cdbef1-7ec4-4a46-9a4c-477f10d39b40"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("562cf1c7-40dc-4e05-9247-16df31df1e2c"), new Guid("8a626148-97c2-4e68-a944-2dddd3d40838"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("f07957ac-4b92-45f9-b286-b60ff8082e0a"), new Guid("0c26f670-b553-4829-9393-21be39b85aee"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "LastName", "Nationality", "Password", "Role" },
                values: new object[] { new Guid("a5311214-564f-4824-ba65-b57042349e49"), new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "gaspard.lammertyn@student.howest.be", "Gaspard", "Lammertyn", "Belgium", "AQAAAAEAACcQAAAAEEX0LWqyWQTYFN72VTYxjOZXFy69pX4FvBPtN+47V5yEFYS+beud4skiNh8TrXFiIg==", "Admin" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryFavourites");

            migrationBuilder.DropTable(
                name: "CountryPhotoMemories");

            migrationBuilder.DropTable(
                name: "CountrySpotifyPlaylist");

            migrationBuilder.DropTable(
                name: "CountryWishlists");

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
