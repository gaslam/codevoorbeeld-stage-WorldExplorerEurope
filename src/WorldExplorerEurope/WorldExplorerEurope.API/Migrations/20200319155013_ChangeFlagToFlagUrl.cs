using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldExplorerEurope.API.Migrations
{
    public partial class ChangeFlagToFlagUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04a3da8d-9448-4d33-a383-3ebdc3575535"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06ed1b97-96b7-4510-a7e4-9fa7138932e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("099eb6f5-2bff-4c9a-88a0-efb4d4e304de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("11cfc48f-a142-4982-bd17-799b495dd788"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18f94ee5-2ffe-44aa-8b64-2bdac51af342"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21ef113d-c4ec-4771-b6b6-5073267a3a56"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25f84048-fa82-4509-8bac-6028d7600a1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27b924c0-73b3-4289-9779-6b25d2854858"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29494f08-25bc-4d10-95f6-5bc52a2b3244"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f52790d-6097-4d7b-81db-5f3111a89bf4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ffcc853-c512-4b1a-bd37-bb53d2638b62"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("39c8be61-4ff5-4e94-9fd0-9cd961c7b684"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f8c387c-518d-4e30-a35d-811ff307e91b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4605d7dc-fb1e-426a-baaa-977ef9d41674"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4717e9d6-3d89-4bd6-9464-279848036153"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d898e25-1dfb-46dc-b5d7-ef8b135ea210"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4de7716f-0bf4-4b71-90a5-02662a43bb27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4eaa01ef-3c4b-4b2e-9748-4be7257d585a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("527d527a-7562-4ce3-996c-98bf16d4903a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5424026c-ba49-41e3-a27f-efb6d421cfa1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("54fe443f-d67a-4dfd-9295-c12c9c5cd898"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("561985d5-eb49-4c17-8ddf-b9ef24a77bf9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ad4650f-58d7-4007-8efc-d6d0bc5d9936"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c1e9011-7c23-4353-8b46-ac7cadd79013"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5ff23976-07fc-4ce4-8795-ac2f27bc06ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6575b88e-5fe1-475c-8a1e-01529c528138"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76517beb-0e8a-4edd-91b3-a47aa49141d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77317fa4-9e12-48f4-829d-418055debaeb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79700b76-328e-4b1c-919d-a399e354a2c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("831aeed8-c8d4-4454-bb2a-7fb83c4bfdd7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c48c711-409f-4777-a9a8-82f12bb5f728"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98ec4433-bca8-407e-a2fa-12e1f952b7af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a256d877-fcda-457a-a19f-2ae982dcdc10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a46a1ed8-a9d9-4a76-ad1a-ac555f53118f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a544fab9-09aa-4beb-80c3-8650922a4c7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa6db11f-35f3-4036-b94c-3eb584cc6dac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af0bb2ff-285d-47af-9ccf-122c6293b767"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bcdf23e0-f5c7-4936-8b27-8c4206150a45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf575251-d314-4ef7-b110-06628798c4ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2caaeb8-6a62-4773-a0f8-1d0ae768b34f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5641df2-eea9-4dbb-b2b6-d3d98709775e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5df7ba8-4797-4755-af85-9e424fee46ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca24a517-1ea5-4065-abe5-2f9da546431c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cca85c2a-d2ec-4db3-81df-cf5d2b3262f8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4e2718f-96f3-483c-8421-46ba95af1436"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e51dfebc-4414-4c4f-9033-38695128d33c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e60e76be-80fa-4fb4-aa1c-824414bc609d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e90b5f06-5a9e-46b4-bef8-efe4184760e1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec9e15c7-05e7-49a7-b8c8-b7c527b7531c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eead3441-fcb0-4039-916d-2aa189a9c1e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4928ec2-a08a-48c3-9978-bd80a65278af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb2bb57c-333e-4d6f-b19d-21850048a799"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff5403a7-32ee-4a7f-8029-e2b55658eb2e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("01d6c757-eb2b-4b28-8501-bae1a7579ce4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("025f989b-3e43-439b-9af8-5360715822fc"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("0cef480f-d643-4d94-ab2e-112d95ed745f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("113081be-7e46-4c70-befb-f13878ed8616"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("130dacef-d38b-4f2b-bf81-2e9320b6d9a9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1e71e711-cc1d-41e1-8268-a7e1447c15f6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("20eae8cb-b4ae-4204-a418-169bf6f9485c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("217a0978-84d4-469a-acc6-911600f1d2d8"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("29c2f850-4289-4fac-a897-a1dce6545ac0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2ccfff1c-3edb-4111-8abc-a505db4d4db2"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2f9c5fdf-20cf-4df3-bc75-65deeaf30905"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("32377605-d668-4d63-9f5d-101329d4d6ef"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("3c3def76-7dac-41b5-a2d5-1a28ec760a7b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("3c59eae6-f521-422f-a6ec-93d1d3ce3f9c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("435c0029-b122-4e7a-8f40-a141ba5c1a6d"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4abccde8-da5a-4b85-9f42-21057ee05d5b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4cb1ded4-83d1-4524-a629-64afffe7c2d9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5ac72679-c8a0-491f-941a-f0c2de6196fe"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("683e17c4-3ad5-48eb-a73a-8f23562098db"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("691fcb15-d6da-4477-911a-79bd99bc0e6f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6eb248e6-a9a0-484c-9c2f-e8cb138318ac"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("749e1978-7f67-4a7e-9976-68d6fb6ff379"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7aab2f5d-4872-4c4e-81a3-683278bbcaad"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8b4f7117-e168-442a-871a-98214c521593"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8b7760d1-7bcf-4327-ba7c-81b3e5e623fc"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8be2831d-a65c-4c8e-823a-95bd5a22e259"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8da37644-415e-4ce1-9c2d-cafd5de3b52d"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("9f6161b2-723b-40ee-bbe7-1118b43024bf"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a25c5b4a-864e-48c6-9b63-7836db498499"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a7a9d74d-7477-4202-a3f5-50698780f0a8"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("aa877ace-abe6-405e-aef6-c07602d18140"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b0575ce4-6bb2-49d9-a23a-c6a9736991d4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b0a10515-de35-491c-873d-9d79f90791c4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b406e4c8-b60d-4009-a903-242b09fd05b3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b4614e8d-01de-45e0-8485-c1d489629dbd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b51c50d2-dc68-4620-aa02-15a7f1622f6f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b89be354-cb54-4315-a416-9cc93cfbe3e3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b8a4274d-50e8-4b9a-a308-823fa0d14855"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("bc6a72ce-2ffe-4f60-a09c-a7bfba5a149a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("bcae843a-6188-4193-91c3-2b8aee923647"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("cfb9f1e2-9e04-4881-994d-3bc2ac446e05"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d006213b-3f94-449b-a597-3c5b12fa3660"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f6e9ccc1-d068-4fac-8b78-38ca13fd350d"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fca76617-40f3-4cd5-9d7f-d2702bd41344"));

            migrationBuilder.DropColumn(
                name: "FlagUrl",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "Flag",
                table: "Countries",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Currency", "Description", "Flag", "IsEUMember", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("1dfa8dd3-5c89-494f-adc3-a5da862781c7"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("53e9416c-2521-4918-aae3-4bb30ac09c99"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("70ba14c5-3afd-4cdd-b79f-7cb8b700f66a"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("63f7a275-9563-4894-815d-d7ed33103429"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("d04a2d2d-83fe-444c-82b9-be218b7d0d17"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("650dc52c-faf5-4ed0-8523-10368f1203e3"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("91c3f933-ee85-4c0b-a12a-d2a3b38959d1"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("07e1bc23-34bd-4bcb-bea4-0bc3f1f99075"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("b416b3c7-870b-46ff-8e6a-8b0bc8d52e39"), "Amsterdam", "Euro", "The Netherlands, often incorrectly termed Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("564c0f41-0411-4168-a32a-323bcfd4bd2f"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("fb9d34d4-67b9-4730-9ff0-c05172538d77"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("0af89895-fd85-4c58-aa7a-0b51f1a1ca42"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("1aeed277-ede9-4699-89c3-3c60c4578102"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("c2bd4f38-8973-4581-9f9b-1950e7dcb8c6"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders with the Black Sea to the southeast, Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometers, Romania is the 12th-largest country in Europe and also the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest, and other major urban areas include Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("087658e7-4669-4cd0-a626-18104b7e576b"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a European country located in Eastern Europe with a vast expanse of territory that stretches across Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects as of 2020, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("96767e8d-2453-4b2c-9644-00c3cbe65554"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("bb45d19b-27e7-44fe-898c-d17e53da2fef"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("287dfa07-cbfc-4a98-a12b-f486881d3481"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("2de26ec5-2f80-442e-95d3-8ddd67742f55"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("79681e36-69be-4a72-b60d-bad1c74c77f6"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("2761aab0-d5ed-47e4-b05b-e30ac096e74d"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.5 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("f63c06fa-ff66-482a-84c1-abc6ccc75ce3"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of western, central, and southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("cc8979d2-27b2-49b9-a8d2-216e782750c9"), "Kiev", "Ukrainian hryvnia", "Ukraine, also known as The Ukraine, is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including Crimea, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it both the largest country entirely within Europe and the 46th largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the 32nd most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("2f96d5cb-af5d-4daa-bf6b-11e8d878da19"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("b0c868cd-0844-424d-9f87-e12b3fd30486"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("d910b9cd-d778-4282-8a1b-799cfce1e13c"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("70801c02-61de-44e7-8086-2c1e7881986a"), "Longyearbyen", "Norwegian krone", @"
                Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("06d4fa99-c926-4b3e-a290-dbf79f4e2544"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("8b78356b-688c-44bf-b21f-a045d4f2b2ac"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("21734474-f17c-4f61-afb1-15a6085e3a61"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("92f7e499-1fd0-4ef6-9104-e32235c0caad"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("88681d5a-7d84-40f9-8131-9ef55f621410"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("81b2b793-03d3-4c62-a056-b0acf71bbf44"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("ab5462cf-97c6-4793-8a74-466df051c215"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("fc52f9ec-bb4d-4fa8-a736-fc2298d9b7be"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("bc8b8e4f-551f-4719-a345-5195ab7edd86"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("809d7494-b12b-4e52-b858-576985c5133b"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("2bae1b3b-c4d7-48e9-a84d-2c5ee6949454"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("433ad0ef-1c41-486d-9be7-d3d753892c26"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("bff94f08-b3a2-4a21-adb9-a92cf669521d"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("3d72f7d2-83c7-41a8-8eea-0d29cba1de4c"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("209db804-d3b4-48e4-acc8-31c9eb650e4f"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("8f2be727-4beb-49da-b10b-d9c04a9f0591"), "Tórshavn", "Danish krone", "The Faroe Islands, or the Faeroe Islands, is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("63101ee6-ae52-4561-be01-a54d46c26b91"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("832ae616-e9df-4e24-a026-d59d1e91e640"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("d0fc94a5-4a10-40a1-b428-64d24702d1e5"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("dbe16c0e-5a02-465c-b74d-8f2e16e53fae"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("2edca96f-bafd-43e2-985c-0bfd2bd9da96"), "Athens", "Euro", "Greece, officially the Hellenic Republic, historically also known as Hellas, is a country located in Southeast Europe. Its population is approximately 10.7 million as of 2018; Athens, the nation's capital, is its largest city, followed by Thessaloniki.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("e5fd30eb-2280-479b-9c59-468f78486342"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("4b1d5cd8-c8b8-4d72-b27e-0700a18b1aed"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, France to the southwest, and Luxembourg, Belgium, and the Netherlands to the west.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("1c250403-3097-4751-a262-3399f5398520"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("b2480a53-91a9-487d-941a-18ddc42df615"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("7edea5d1-a3ff-4389-b18d-8b7eb7406c5c"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("6713e14c-e7ab-453d-99bf-3f3e8c4ff1dd"), new Guid("63f7a275-9563-4894-815d-d7ed33103429"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("7b9cf4ec-0231-457d-adf0-de3acbcc8e8c"), new Guid("650dc52c-faf5-4ed0-8523-10368f1203e3"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("7eca5b3e-9ca8-4379-ac20-61d7a0ee6fa9"), new Guid("1aeed277-ede9-4699-89c3-3c60c4578102"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("f07bed57-1061-4b0d-ab00-891f9d062d81"), new Guid("91c3f933-ee85-4c0b-a12a-d2a3b38959d1"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("838407ae-6296-4676-9169-28ed21351e6f"), new Guid("07e1bc23-34bd-4bcb-bea4-0bc3f1f99075"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("85c8e6e7-66f5-4d92-a8fb-c344018fd0e8"), new Guid("b416b3c7-870b-46ff-8e6a-8b0bc8d52e39"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("c7997b18-4fbd-46f5-801b-c6f7c966817c"), new Guid("564c0f41-0411-4168-a32a-323bcfd4bd2f"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("c35c4814-8844-4b6a-b1e2-659849083c9f"), new Guid("fb9d34d4-67b9-4730-9ff0-c05172538d77"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("899efafb-28a7-4b11-bdd7-51d6134833f3"), new Guid("0af89895-fd85-4c58-aa7a-0b51f1a1ca42"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("86771f31-2a63-4cc5-90b4-d6964bd741ac"), new Guid("287dfa07-cbfc-4a98-a12b-f486881d3481"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("8f4c4ef9-6d3e-4b1b-877b-3c3da3b4b63a"), new Guid("087658e7-4669-4cd0-a626-18104b7e576b"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("dc4e85b2-1f36-44de-91c6-96bd8c337a98"), new Guid("96767e8d-2453-4b2c-9644-00c3cbe65554"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("d43f4e00-914c-44a6-bdfb-1c641342bfae"), new Guid("bb45d19b-27e7-44fe-898c-d17e53da2fef"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("c4e01b63-38f5-41b5-84f1-0ea693242478"), new Guid("79681e36-69be-4a72-b60d-bad1c74c77f6"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("7b57810e-9d9d-4829-b0fc-366ab720ceef"), new Guid("70801c02-61de-44e7-8086-2c1e7881986a"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("664a9b78-1305-4ef8-92b4-a156d5332520"), new Guid("2761aab0-d5ed-47e4-b05b-e30ac096e74d"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("98cee1cd-9dc5-4f51-a576-424a620ec606"), new Guid("f63c06fa-ff66-482a-84c1-abc6ccc75ce3"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("b2aa59c7-4a25-4566-b540-eb1e9f825db9"), new Guid("70ba14c5-3afd-4cdd-b79f-7cb8b700f66a"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("38f6782f-86f1-48de-9e5c-4ae0348bb102"), new Guid("cc8979d2-27b2-49b9-a8d2-216e782750c9"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("e43845c7-7315-40f9-95c1-a0bffebad7e6"), new Guid("c2bd4f38-8973-4581-9f9b-1950e7dcb8c6"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("ee0a8db5-b376-4ebe-9adb-27eab3dff665"), new Guid("53e9416c-2521-4918-aae3-4bb30ac09c99"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("58cf546c-8a96-4de9-bc37-57f67ae7604b"), new Guid("433ad0ef-1c41-486d-9be7-d3d753892c26"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("aef16cf1-a6d9-4387-80d4-653dc37199e4"), new Guid("7edea5d1-a3ff-4389-b18d-8b7eb7406c5c"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("56e16fad-f325-452b-b861-5508053725f3"), new Guid("2f96d5cb-af5d-4daa-bf6b-11e8d878da19"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("da5924cd-6882-4ab1-9475-f90bd649371b"), new Guid("1dfa8dd3-5c89-494f-adc3-a5da862781c7"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("7cd82935-f809-441e-8f7d-a950f00f1dd4"), new Guid("21734474-f17c-4f61-afb1-15a6085e3a61"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("d650d3af-3516-4b1c-abcf-b1b8a6be1918"), new Guid("3d72f7d2-83c7-41a8-8eea-0d29cba1de4c"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("b7428f13-3f2b-4b5b-bcb6-97fb620337c4"), new Guid("88681d5a-7d84-40f9-8131-9ef55f621410"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("d11b3300-6cf9-4b36-bfe1-de44ba1b7b65"), new Guid("81b2b793-03d3-4c62-a056-b0acf71bbf44"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("abd404a3-a7d6-493d-97b8-b55e8ae7a4e2"), new Guid("fc52f9ec-bb4d-4fa8-a736-fc2298d9b7be"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("7ebaec1a-ca61-4900-bb52-3ed01588d519"), new Guid("bc8b8e4f-551f-4719-a345-5195ab7edd86"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("ead395c9-a7a7-4f5a-acbe-160f932b91d2"), new Guid("809d7494-b12b-4e52-b858-576985c5133b"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("c26401f9-fa3a-49ad-8ac7-b78b07931d92"), new Guid("06d4fa99-c926-4b3e-a290-dbf79f4e2544"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("96f47354-487d-4c06-9ba9-548f954e57ff"), new Guid("2bae1b3b-c4d7-48e9-a84d-2c5ee6949454"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("9c86d84e-8bb2-4c25-8032-c2e9a166f446"), new Guid("8f2be727-4beb-49da-b10b-d9c04a9f0591"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("a20ec5f3-f62c-46af-9abb-804a139cd7f3"), new Guid("209db804-d3b4-48e4-acc8-31c9eb650e4f"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("cebf29c1-a84c-4e17-87df-8004171d6291"), new Guid("1c250403-3097-4751-a262-3399f5398520"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("11958094-3a51-4915-8b94-c93aa337a046"), new Guid("4b1d5cd8-c8b8-4d72-b27e-0700a18b1aed"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("57779000-033b-42ec-a674-bb343511fbd0"), new Guid("e5fd30eb-2280-479b-9c59-468f78486342"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("770cbd65-9463-4c2d-b129-2c86f04898e6"), new Guid("2edca96f-bafd-43e2-985c-0bfd2bd9da96"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("00fcfb69-d9e8-466e-abe7-c4489ecb0714"), new Guid("832ae616-e9df-4e24-a026-d59d1e91e640"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("054f7126-a642-4624-94a5-8318c292374b"), new Guid("dbe16c0e-5a02-465c-b74d-8f2e16e53fae"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("2cbad5e0-b4f0-48e3-89c9-ad54cda0258b"), new Guid("63101ee6-ae52-4561-be01-a54d46c26b91"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("e174c704-f7c7-4e07-9913-d00d0eb164ca"), new Guid("bff94f08-b3a2-4a21-adb9-a92cf669521d"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5311214-564f-4824-ba65-b57042349e49"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEOKyJT34PGeK9mSE8JCHk7DUTpiqDYOV0HYQ4r94bqxE7IvYqjKFLom3KUs4puFIgA==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06d4fa99-c926-4b3e-a290-dbf79f4e2544"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07e1bc23-34bd-4bcb-bea4-0bc3f1f99075"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("087658e7-4669-4cd0-a626-18104b7e576b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0af89895-fd85-4c58-aa7a-0b51f1a1ca42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1aeed277-ede9-4699-89c3-3c60c4578102"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c250403-3097-4751-a262-3399f5398520"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1dfa8dd3-5c89-494f-adc3-a5da862781c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("209db804-d3b4-48e4-acc8-31c9eb650e4f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21734474-f17c-4f61-afb1-15a6085e3a61"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2761aab0-d5ed-47e4-b05b-e30ac096e74d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("287dfa07-cbfc-4a98-a12b-f486881d3481"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2bae1b3b-c4d7-48e9-a84d-2c5ee6949454"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2de26ec5-2f80-442e-95d3-8ddd67742f55"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2edca96f-bafd-43e2-985c-0bfd2bd9da96"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2f96d5cb-af5d-4daa-bf6b-11e8d878da19"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3d72f7d2-83c7-41a8-8eea-0d29cba1de4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("433ad0ef-1c41-486d-9be7-d3d753892c26"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b1d5cd8-c8b8-4d72-b27e-0700a18b1aed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("53e9416c-2521-4918-aae3-4bb30ac09c99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("564c0f41-0411-4168-a32a-323bcfd4bd2f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63101ee6-ae52-4561-be01-a54d46c26b91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63f7a275-9563-4894-815d-d7ed33103429"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("650dc52c-faf5-4ed0-8523-10368f1203e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70801c02-61de-44e7-8086-2c1e7881986a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70ba14c5-3afd-4cdd-b79f-7cb8b700f66a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("79681e36-69be-4a72-b60d-bad1c74c77f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7edea5d1-a3ff-4389-b18d-8b7eb7406c5c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("809d7494-b12b-4e52-b858-576985c5133b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("81b2b793-03d3-4c62-a056-b0acf71bbf44"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("832ae616-e9df-4e24-a026-d59d1e91e640"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("88681d5a-7d84-40f9-8131-9ef55f621410"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b78356b-688c-44bf-b21f-a045d4f2b2ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f2be727-4beb-49da-b10b-d9c04a9f0591"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91c3f933-ee85-4c0b-a12a-d2a3b38959d1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92f7e499-1fd0-4ef6-9104-e32235c0caad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96767e8d-2453-4b2c-9644-00c3cbe65554"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ab5462cf-97c6-4793-8a74-466df051c215"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0c868cd-0844-424d-9f87-e12b3fd30486"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b2480a53-91a9-487d-941a-18ddc42df615"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b416b3c7-870b-46ff-8e6a-8b0bc8d52e39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb45d19b-27e7-44fe-898c-d17e53da2fef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc8b8e4f-551f-4719-a345-5195ab7edd86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bff94f08-b3a2-4a21-adb9-a92cf669521d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2bd4f38-8973-4581-9f9b-1950e7dcb8c6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc8979d2-27b2-49b9-a8d2-216e782750c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d04a2d2d-83fe-444c-82b9-be218b7d0d17"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0fc94a5-4a10-40a1-b428-64d24702d1e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d910b9cd-d778-4282-8a1b-799cfce1e13c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dbe16c0e-5a02-465c-b74d-8f2e16e53fae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e5fd30eb-2280-479b-9c59-468f78486342"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f63c06fa-ff66-482a-84c1-abc6ccc75ce3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb9d34d4-67b9-4730-9ff0-c05172538d77"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc52f9ec-bb4d-4fa8-a736-fc2298d9b7be"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("00fcfb69-d9e8-466e-abe7-c4489ecb0714"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("054f7126-a642-4624-94a5-8318c292374b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("11958094-3a51-4915-8b94-c93aa337a046"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2cbad5e0-b4f0-48e3-89c9-ad54cda0258b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("38f6782f-86f1-48de-9e5c-4ae0348bb102"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("56e16fad-f325-452b-b861-5508053725f3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("57779000-033b-42ec-a674-bb343511fbd0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("58cf546c-8a96-4de9-bc37-57f67ae7604b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("664a9b78-1305-4ef8-92b4-a156d5332520"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6713e14c-e7ab-453d-99bf-3f3e8c4ff1dd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("770cbd65-9463-4c2d-b129-2c86f04898e6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7b57810e-9d9d-4829-b0fc-366ab720ceef"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7b9cf4ec-0231-457d-adf0-de3acbcc8e8c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7cd82935-f809-441e-8f7d-a950f00f1dd4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7ebaec1a-ca61-4900-bb52-3ed01588d519"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7eca5b3e-9ca8-4379-ac20-61d7a0ee6fa9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("838407ae-6296-4676-9169-28ed21351e6f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("85c8e6e7-66f5-4d92-a8fb-c344018fd0e8"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("86771f31-2a63-4cc5-90b4-d6964bd741ac"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("899efafb-28a7-4b11-bdd7-51d6134833f3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8f4c4ef9-6d3e-4b1b-877b-3c3da3b4b63a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("96f47354-487d-4c06-9ba9-548f954e57ff"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("98cee1cd-9dc5-4f51-a576-424a620ec606"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("9c86d84e-8bb2-4c25-8032-c2e9a166f446"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a20ec5f3-f62c-46af-9abb-804a139cd7f3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("abd404a3-a7d6-493d-97b8-b55e8ae7a4e2"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("aef16cf1-a6d9-4387-80d4-653dc37199e4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b2aa59c7-4a25-4566-b540-eb1e9f825db9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b7428f13-3f2b-4b5b-bcb6-97fb620337c4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c26401f9-fa3a-49ad-8ac7-b78b07931d92"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c35c4814-8844-4b6a-b1e2-659849083c9f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c4e01b63-38f5-41b5-84f1-0ea693242478"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c7997b18-4fbd-46f5-801b-c6f7c966817c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("cebf29c1-a84c-4e17-87df-8004171d6291"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d11b3300-6cf9-4b36-bfe1-de44ba1b7b65"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d43f4e00-914c-44a6-bdfb-1c641342bfae"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d650d3af-3516-4b1c-abcf-b1b8a6be1918"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("da5924cd-6882-4ab1-9475-f90bd649371b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("dc4e85b2-1f36-44de-91c6-96bd8c337a98"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e174c704-f7c7-4e07-9913-d00d0eb164ca"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e43845c7-7315-40f9-95c1-a0bffebad7e6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ead395c9-a7a7-4f5a-acbe-160f932b91d2"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ee0a8db5-b376-4ebe-9adb-27eab3dff665"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f07bed57-1061-4b0d-ab00-891f9d062d81"));

            migrationBuilder.DropColumn(
                name: "Flag",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "FlagUrl",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Currency", "Description", "FlagUrl", "IsEUMember", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("bf575251-d314-4ef7-b110-06628798c4ca"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("2f52790d-6097-4d7b-81db-5f3111a89bf4"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("27b924c0-73b3-4289-9779-6b25d2854858"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("561985d5-eb49-4c17-8ddf-b9ef24a77bf9"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("a256d877-fcda-457a-a19f-2ae982dcdc10"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("5c1e9011-7c23-4353-8b46-ac7cadd79013"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("98ec4433-bca8-407e-a2fa-12e1f952b7af"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("c5641df2-eea9-4dbb-b2b6-d3d98709775e"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("29494f08-25bc-4d10-95f6-5bc52a2b3244"), "Amsterdam", "Euro", "The Netherlands, often incorrectly termed Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("18f94ee5-2ffe-44aa-8b64-2bdac51af342"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("5ad4650f-58d7-4007-8efc-d6d0bc5d9936"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("5ff23976-07fc-4ce4-8795-ac2f27bc06ce"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("04a3da8d-9448-4d33-a383-3ebdc3575535"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("099eb6f5-2bff-4c9a-88a0-efb4d4e304de"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders with the Black Sea to the southeast, Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometers, Romania is the 12th-largest country in Europe and also the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest, and other major urban areas include Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("fb2bb57c-333e-4d6f-b19d-21850048a799"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a European country located in Eastern Europe with a vast expanse of territory that stretches across Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects as of 2020, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("cca85c2a-d2ec-4db3-81df-cf5d2b3262f8"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("ca24a517-1ea5-4065-abe5-2f9da546431c"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a land-locked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("831aeed8-c8d4-4454-bb2a-7fb83c4bfdd7"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("ff5403a7-32ee-4a7f-8029-e2b55658eb2e"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("4eaa01ef-3c4b-4b2e-9748-4be7257d585a"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("4605d7dc-fb1e-426a-baaa-977ef9d41674"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.5 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("c2caaeb8-6a62-4773-a0f8-1d0ae768b34f"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of western, central, and southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("af0bb2ff-285d-47af-9ccf-122c6293b767"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including Crimea, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it both the largest country entirely within Europe and the 46th largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the 32nd most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("5424026c-ba49-41e3-a27f-efb6d421cfa1"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("06ed1b97-96b7-4510-a7e4-9fa7138932e5"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("2ffcc853-c512-4b1a-bd37-bb53d2638b62"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("aa6db11f-35f3-4036-b94c-3eb584cc6dac"), "Longyearbyen", "Norwegian krone", @"
                Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("25f84048-fa82-4509-8bac-6028d7600a1e"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("3f8c387c-518d-4e30-a35d-811ff307e91b"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("6575b88e-5fe1-475c-8a1e-01529c528138"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("76517beb-0e8a-4edd-91b3-a47aa49141d1"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("e90b5f06-5a9e-46b4-bef8-efe4184760e1"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("ec9e15c7-05e7-49a7-b8c8-b7c527b7531c"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("a544fab9-09aa-4beb-80c3-8650922a4c7a"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("21ef113d-c4ec-4771-b6b6-5073267a3a56"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("11cfc48f-a142-4982-bd17-799b495dd788"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("4717e9d6-3d89-4bd6-9464-279848036153"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("4de7716f-0bf4-4b71-90a5-02662a43bb27"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a Landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("4d898e25-1dfb-46dc-b5d7-ef8b135ea210"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("eead3441-fcb0-4039-916d-2aa189a9c1e4"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("527d527a-7562-4ce3-996c-98bf16d4903a"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("39c8be61-4ff5-4e94-9fd0-9cd961c7b684"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("77317fa4-9e12-48f4-829d-418055debaeb"), "Tórshavn", "Danish krone", "The Faroe Islands, or the Faeroe Islands, is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("f4928ec2-a08a-48c3-9978-bd80a65278af"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("54fe443f-d67a-4dfd-9295-c12c9c5cd898"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("e4e2718f-96f3-483c-8421-46ba95af1436"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("c5df7ba8-4797-4755-af85-9e424fee46ef"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("79700b76-328e-4b1c-919d-a399e354a2c6"), "Athens", "Euro", "Greece, officially the Hellenic Republic, historically also known as Hellas, is a country located in Southeast Europe. Its population is approximately 10.7 million as of 2018; Athens, the nation's capital, is its largest city, followed by Thessaloniki.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("bcdf23e0-f5c7-4936-8b27-8c4206150a45"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("e51dfebc-4414-4c4f-9033-38695128d33c"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, France to the southwest, and Luxembourg, Belgium, and the Netherlands to the west.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("8c48c711-409f-4777-a9a8-82f12bb5f728"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("a46a1ed8-a9d9-4a76-ad1a-ac555f53118f"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("e60e76be-80fa-4fb4-aa1c-824414bc609d"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("435c0029-b122-4e7a-8f40-a141ba5c1a6d"), new Guid("561985d5-eb49-4c17-8ddf-b9ef24a77bf9"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("9f6161b2-723b-40ee-bbe7-1118b43024bf"), new Guid("5c1e9011-7c23-4353-8b46-ac7cadd79013"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("32377605-d668-4d63-9f5d-101329d4d6ef"), new Guid("04a3da8d-9448-4d33-a383-3ebdc3575535"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("025f989b-3e43-439b-9af8-5360715822fc"), new Guid("98ec4433-bca8-407e-a2fa-12e1f952b7af"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("a25c5b4a-864e-48c6-9b63-7836db498499"), new Guid("c5641df2-eea9-4dbb-b2b6-d3d98709775e"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("bcae843a-6188-4193-91c3-2b8aee923647"), new Guid("29494f08-25bc-4d10-95f6-5bc52a2b3244"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("3c3def76-7dac-41b5-a2d5-1a28ec760a7b"), new Guid("18f94ee5-2ffe-44aa-8b64-2bdac51af342"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("2f9c5fdf-20cf-4df3-bc75-65deeaf30905"), new Guid("5ad4650f-58d7-4007-8efc-d6d0bc5d9936"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("217a0978-84d4-469a-acc6-911600f1d2d8"), new Guid("5ff23976-07fc-4ce4-8795-ac2f27bc06ce"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("b0575ce4-6bb2-49d9-a23a-c6a9736991d4"), new Guid("831aeed8-c8d4-4454-bb2a-7fb83c4bfdd7"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("130dacef-d38b-4f2b-bf81-2e9320b6d9a9"), new Guid("fb2bb57c-333e-4d6f-b19d-21850048a799"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("b406e4c8-b60d-4009-a903-242b09fd05b3"), new Guid("cca85c2a-d2ec-4db3-81df-cf5d2b3262f8"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("20eae8cb-b4ae-4204-a418-169bf6f9485c"), new Guid("ca24a517-1ea5-4065-abe5-2f9da546431c"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("29c2f850-4289-4fac-a897-a1dce6545ac0"), new Guid("4eaa01ef-3c4b-4b2e-9748-4be7257d585a"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("8be2831d-a65c-4c8e-823a-95bd5a22e259"), new Guid("aa6db11f-35f3-4036-b94c-3eb584cc6dac"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("a7a9d74d-7477-4202-a3f5-50698780f0a8"), new Guid("4605d7dc-fb1e-426a-baaa-977ef9d41674"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("6eb248e6-a9a0-484c-9c2f-e8cb138318ac"), new Guid("c2caaeb8-6a62-4773-a0f8-1d0ae768b34f"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("b51c50d2-dc68-4620-aa02-15a7f1622f6f"), new Guid("27b924c0-73b3-4289-9779-6b25d2854858"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("2ccfff1c-3edb-4111-8abc-a505db4d4db2"), new Guid("af0bb2ff-285d-47af-9ccf-122c6293b767"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("8da37644-415e-4ce1-9c2d-cafd5de3b52d"), new Guid("099eb6f5-2bff-4c9a-88a0-efb4d4e304de"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("4cb1ded4-83d1-4524-a629-64afffe7c2d9"), new Guid("2f52790d-6097-4d7b-81db-5f3111a89bf4"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("aa877ace-abe6-405e-aef6-c07602d18140"), new Guid("4d898e25-1dfb-46dc-b5d7-ef8b135ea210"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("691fcb15-d6da-4477-911a-79bd99bc0e6f"), new Guid("e60e76be-80fa-4fb4-aa1c-824414bc609d"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("bc6a72ce-2ffe-4f60-a09c-a7bfba5a149a"), new Guid("5424026c-ba49-41e3-a27f-efb6d421cfa1"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("b4614e8d-01de-45e0-8485-c1d489629dbd"), new Guid("bf575251-d314-4ef7-b110-06628798c4ca"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("5ac72679-c8a0-491f-941a-f0c2de6196fe"), new Guid("6575b88e-5fe1-475c-8a1e-01529c528138"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("683e17c4-3ad5-48eb-a73a-8f23562098db"), new Guid("527d527a-7562-4ce3-996c-98bf16d4903a"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("d006213b-3f94-449b-a597-3c5b12fa3660"), new Guid("e90b5f06-5a9e-46b4-bef8-efe4184760e1"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("8b4f7117-e168-442a-871a-98214c521593"), new Guid("ec9e15c7-05e7-49a7-b8c8-b7c527b7531c"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("b8a4274d-50e8-4b9a-a308-823fa0d14855"), new Guid("21ef113d-c4ec-4771-b6b6-5073267a3a56"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("f6e9ccc1-d068-4fac-8b78-38ca13fd350d"), new Guid("11cfc48f-a142-4982-bd17-799b495dd788"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("3c59eae6-f521-422f-a6ec-93d1d3ce3f9c"), new Guid("4717e9d6-3d89-4bd6-9464-279848036153"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("1e71e711-cc1d-41e1-8268-a7e1447c15f6"), new Guid("25f84048-fa82-4509-8bac-6028d7600a1e"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("7aab2f5d-4872-4c4e-81a3-683278bbcaad"), new Guid("4de7716f-0bf4-4b71-90a5-02662a43bb27"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("8b7760d1-7bcf-4327-ba7c-81b3e5e623fc"), new Guid("77317fa4-9e12-48f4-829d-418055debaeb"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("749e1978-7f67-4a7e-9976-68d6fb6ff379"), new Guid("39c8be61-4ff5-4e94-9fd0-9cd961c7b684"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("0cef480f-d643-4d94-ab2e-112d95ed745f"), new Guid("8c48c711-409f-4777-a9a8-82f12bb5f728"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("113081be-7e46-4c70-befb-f13878ed8616"), new Guid("e51dfebc-4414-4c4f-9033-38695128d33c"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("b89be354-cb54-4315-a416-9cc93cfbe3e3"), new Guid("bcdf23e0-f5c7-4936-8b27-8c4206150a45"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("fca76617-40f3-4cd5-9d7f-d2702bd41344"), new Guid("79700b76-328e-4b1c-919d-a399e354a2c6"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("b0a10515-de35-491c-873d-9d79f90791c4"), new Guid("54fe443f-d67a-4dfd-9295-c12c9c5cd898"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("4abccde8-da5a-4b85-9f42-21057ee05d5b"), new Guid("c5df7ba8-4797-4755-af85-9e424fee46ef"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("01d6c757-eb2b-4b28-8501-bae1a7579ce4"), new Guid("f4928ec2-a08a-48c3-9978-bd80a65278af"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("cfb9f1e2-9e04-4881-994d-3bc2ac446e05"), new Guid("eead3441-fcb0-4039-916d-2aa189a9c1e4"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5311214-564f-4824-ba65-b57042349e49"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEEXsvE62psUgJij90QASH6Uxu07UCkdcMKnM+kDLGnluvgLcUq+wvSyQWX93d64/AQ==");
        }
    }
}
