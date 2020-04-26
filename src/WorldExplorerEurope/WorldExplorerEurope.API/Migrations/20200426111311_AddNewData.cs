using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldExplorerEurope.API.Migrations
{
    public partial class AddNewData : Migration
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
                    IsAdmin = table.Column<bool>(nullable: false)
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
                    WishlistId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
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
                    { new Guid("c46e3466-155f-4935-b4c3-409851275d98"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("7beaf82b-000a-4671-a66d-3fb255000186"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("94fba9ce-9cd3-4366-8b29-9293859ebdc1"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("8eb30f25-de6c-481d-80bb-09025a51d8f4"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("735d43de-cdfe-4bda-8a93-25c354f5babc"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("52f58147-3770-4127-a39f-ee154b3bcf67"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("dd9736d5-1e34-47c4-bfaf-ec3ef927deef"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("4ff4038c-dd4e-4262-8e82-6a1c453032d1"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("39129865-8b34-4873-b1f6-1e4e8b0d0810"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("5b9c556c-d58b-44bb-beb3-0e05c54b56c0"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("6c92f228-8f38-4e1b-be78-a666a76a00e2"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("79f4f066-c6c4-428a-91f6-2c996a666312"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("717027d1-e9f8-431e-b391-5f83652ae05a"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("24bc1df5-4c0f-4159-ae86-7283a65d8be3"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("54f2d321-6e81-4f37-adf9-d501b88f3ffe"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("fe44e044-eaa7-494a-8922-e1a51e3cdda3"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("3d2f40d9-fa09-4919-a716-dbdb52220b23"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("e312ec4a-191b-4054-8d86-a8f4f393118b"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("85021e5c-b8db-4533-a4fe-7f9474f1f909"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("f5788ba7-6c9f-4846-be72-f4d3fb50c342"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("b548f02e-c34c-4eff-afbf-102011e42a71"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("902dbd21-21d9-4a86-9973-dbce425689f4"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("508d61c8-e4b1-4068-adc9-eb6fad1bd89a"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("270ac7e1-b893-480c-8241-9a28b90f4ecc"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("941b51b4-284c-46e1-878b-c430e8be34e7"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("f819bd08-1262-405d-b90e-7d91634d999f"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("5cd0e758-55ee-4d0e-8c66-0b40cada663f"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("9969cf09-7d73-4b07-b85f-2956ba90c5d5"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("3d250fd1-f378-4269-b25d-4526cdd2bf44"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("97ed2710-db3c-4c9c-ae71-766956390db5"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("03361b83-2b49-48a2-aec2-989a93b5bb8a"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("b9d1bf06-ed65-4625-8af3-422fe809d7bb"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("6ca8e2f5-145f-45a4-bfd1-5ccbec938499"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("92e2585c-592f-4ab0-95d6-6b7bb72bfb49"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("166a5565-099f-454e-b291-9dec1fbc70d8"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("0c12ef66-9d27-47a3-80c1-c5ee228ee697"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("de78b490-b09e-4f0a-8fda-b1bc4b58f454"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("ac0b1b4e-905e-4ae4-b515-b09161612812"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("95c85721-2d7a-4b15-a824-d8a7b328a45c"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("ad2c4dbb-eb37-4d24-9748-fbd83430a015"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("1fa574fc-f92f-4650-af34-331905fa5f80"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("13ac7d2a-e061-4efc-a6b7-dd42b57f3bdf"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("c8e7997a-319d-484d-a8b6-e24fe3862dd0"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("4112c642-10a3-459b-a7fb-defa53ae4057"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("cb333fcd-837c-4c81-96f0-b5ad802409e2"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("e15eb271-399a-4d4a-931f-8deac506269d"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("157d6ab1-2137-4141-b9a1-6406b278c495"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("2d0ec4d7-bf15-4cbc-b2bb-db1cfe12afbc"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("1c8f1a2d-3001-42e0-805c-0122320d5ee1"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("5b0c5a00-d08a-4603-8eee-70922f70ae9c"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("0e6d3293-c42f-4187-b82f-99620ec3902c"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("28eb2df8-393b-41b5-956e-02d63f3370e4"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("b180841b-0a83-4b23-ba01-998d3cb65c9b"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("9122e18a-0b49-4621-84f3-a33702708ddf"), new Guid("8eb30f25-de6c-481d-80bb-09025a51d8f4"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("0b327ff1-3410-42c0-a2db-03345077ebcf"), new Guid("52f58147-3770-4127-a39f-ee154b3bcf67"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("76324177-fbca-4bd0-96be-dccb2c1d4794"), new Guid("717027d1-e9f8-431e-b391-5f83652ae05a"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("d3c7c2a1-6567-4e4e-af1f-d700cce4b9d1"), new Guid("dd9736d5-1e34-47c4-bfaf-ec3ef927deef"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("03fac0e7-4f7c-4cd0-8328-2b506d9dc4a3"), new Guid("4ff4038c-dd4e-4262-8e82-6a1c453032d1"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("cd01d0dd-a3bd-45fd-b211-0d9d0dd53c78"), new Guid("39129865-8b34-4873-b1f6-1e4e8b0d0810"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("3f206e5a-069e-41e6-9fab-4a91122b9bd1"), new Guid("5b9c556c-d58b-44bb-beb3-0e05c54b56c0"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("e64095f4-2c4e-4d33-bbfe-f9bffc6f3a6b"), new Guid("6c92f228-8f38-4e1b-be78-a666a76a00e2"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("adb515d7-4414-42b8-af74-d8eea27a00f0"), new Guid("79f4f066-c6c4-428a-91f6-2c996a666312"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("1ca2dbc9-683d-4e46-a63f-6a74967af8a5"), new Guid("e312ec4a-191b-4054-8d86-a8f4f393118b"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("ff0844ae-c426-4ce4-ab5a-7674e9984929"), new Guid("54f2d321-6e81-4f37-adf9-d501b88f3ffe"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("a005e3d1-06c1-4858-becd-cdbd92f36c27"), new Guid("fe44e044-eaa7-494a-8922-e1a51e3cdda3"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("89ef2e3f-1c7c-4c59-9a80-93d444801204"), new Guid("3d2f40d9-fa09-4919-a716-dbdb52220b23"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("0105718a-f4ca-4ec4-9409-1392894af19e"), new Guid("f5788ba7-6c9f-4846-be72-f4d3fb50c342"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("b564d615-033b-49ab-976d-7be962a8c0e0"), new Guid("5cd0e758-55ee-4d0e-8c66-0b40cada663f"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("8eae18ed-661f-46e1-851c-855ab2db5db6"), new Guid("b548f02e-c34c-4eff-afbf-102011e42a71"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("79b2da37-3fa9-4a74-ab75-ba69c7a85546"), new Guid("902dbd21-21d9-4a86-9973-dbce425689f4"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("e5592be8-0a02-4516-bd2b-d85c6372dbe6"), new Guid("94fba9ce-9cd3-4366-8b29-9293859ebdc1"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("1812dacc-48e5-456c-88e0-aaae1a6e5dd9"), new Guid("508d61c8-e4b1-4068-adc9-eb6fad1bd89a"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("bb5fefbf-8ccb-4021-98b9-b8ca826ce42a"), new Guid("24bc1df5-4c0f-4159-ae86-7283a65d8be3"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("0fd5aeb6-cf38-4b14-9226-43c74b72f575"), new Guid("7beaf82b-000a-4671-a66d-3fb255000186"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("efcd23ef-8629-4e6d-8d45-f162d58023ab"), new Guid("95c85721-2d7a-4b15-a824-d8a7b328a45c"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("6475d9a5-52ed-4712-825c-aeec97273180"), new Guid("b180841b-0a83-4b23-ba01-998d3cb65c9b"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("df6eee95-7c3e-4727-bf8d-32efa18133e5"), new Guid("270ac7e1-b893-480c-8241-9a28b90f4ecc"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("1d58c72b-287b-4a78-b3af-551636f412bc"), new Guid("c46e3466-155f-4935-b4c3-409851275d98"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("fd538bb4-f635-4126-bf80-e0f6a92c61f5"), new Guid("97ed2710-db3c-4c9c-ae71-766956390db5"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("6a7b25d3-3f1b-4c9a-86b2-ba080b21d3c6"), new Guid("1fa574fc-f92f-4650-af34-331905fa5f80"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("c7b1bbaf-bb43-4610-bed9-c4a2bf03b7de"), new Guid("b9d1bf06-ed65-4625-8af3-422fe809d7bb"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("fc1b6123-c458-40f0-aa82-dee482c531a4"), new Guid("6ca8e2f5-145f-45a4-bfd1-5ccbec938499"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("00a87cd8-40e7-468c-bb16-f242319c18c3"), new Guid("166a5565-099f-454e-b291-9dec1fbc70d8"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("17f1d4f7-8c5b-4836-8f96-a17a899677b5"), new Guid("0c12ef66-9d27-47a3-80c1-c5ee228ee697"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("1aebade9-2265-4ada-92ef-20db4b098558"), new Guid("de78b490-b09e-4f0a-8fda-b1bc4b58f454"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("825c40f5-3610-4b88-9f88-a460cad3d3ff"), new Guid("9969cf09-7d73-4b07-b85f-2956ba90c5d5"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("c16c0493-e531-4192-86ce-721c3676010e"), new Guid("ac0b1b4e-905e-4ae4-b515-b09161612812"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("9ff1e955-b718-4f20-b08e-89dbe8cda978"), new Guid("c8e7997a-319d-484d-a8b6-e24fe3862dd0"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("9f9882d9-ebf9-41f7-9da6-9ea4d4a01375"), new Guid("13ac7d2a-e061-4efc-a6b7-dd42b57f3bdf"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("34a026a1-3dd1-4af5-bb7e-456020d7e604"), new Guid("0e6d3293-c42f-4187-b82f-99620ec3902c"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("76c9107e-2b2a-442a-adac-7fd7545d5a26"), new Guid("5b0c5a00-d08a-4603-8eee-70922f70ae9c"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("b4f29757-8097-41c6-bfd5-7706eba48ba7"), new Guid("1c8f1a2d-3001-42e0-805c-0122320d5ee1"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("394e8480-0c52-43db-aa4b-9e6475f7f63a"), new Guid("2d0ec4d7-bf15-4cbc-b2bb-db1cfe12afbc"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("9cb39cf8-244d-4d67-8230-c77aef436751"), new Guid("cb333fcd-837c-4c81-96f0-b5ad802409e2"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("9fc0c1c0-6c1e-4bde-ae70-fd52bc63ca21"), new Guid("157d6ab1-2137-4141-b9a1-6406b278c495"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("6a3ce54a-2a09-4a86-96f0-cf109ec6400c"), new Guid("4112c642-10a3-459b-a7fb-defa53ae4057"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("0853e31d-bac3-4d25-8a2c-ae04ac495786"), new Guid("ad2c4dbb-eb37-4d24-9748-fbd83430a015"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "FirstName", "IsAdmin", "LastName", "Nationality", "Password" },
                values: new object[] { new Guid("a5311214-564f-4824-ba65-b57042349e49"), new DateTime(1998, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "gaspard.lammertyn@student.howest.be", "Gaspard", true, "Lammertyn", "Belgium", "AQAAAAEAACcQAAAAEFdJ688jSDlO18iBNx10UteySnls8QJt+yGSUgNLNgT30Dumi3lEMaInTs4G5kpwbA==" });

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
