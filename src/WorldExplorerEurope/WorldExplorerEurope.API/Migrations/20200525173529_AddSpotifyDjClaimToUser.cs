using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldExplorerEurope.API.Migrations
{
    public partial class AddSpotifyDjClaimToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00d81e42-04d3-43dd-b6b3-4ec42cd80497"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("044f3e1a-a5df-495e-8f01-f8bd2caf7615"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0592b07e-a077-4bd2-a69d-abbb59894b3a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("07ff30e1-ab00-45de-b057-8ae2e412b242"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c6193a3-9e55-4bf9-ad4a-a78b6ebd1386"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e0e745c-a00d-45db-a869-c27618e6d3ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e8c8f29-9f39-491a-94fc-5288204fe9ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("142bc481-3ed9-4fd1-8a1a-0ca7f3f3cca1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15d78f70-6b9b-4bf6-8028-a1586991af67"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1632e94b-8d85-4059-95de-031dfd29487c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18f5651a-8749-4793-a3fd-15e9920f2a65"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1e980c3f-1cfe-4e5c-a4e5-7da736dda998"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2026c7e7-f6bb-4827-9a2b-825a29c10929"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25c815a4-e84b-4785-ad20-da974dd3391e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28d64068-3008-4dc4-91c4-475508b141e9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29b60e4b-e25d-453f-9708-38179c7c4a63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2cec81d5-65af-47e1-b328-37b81fe5fd16"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("317525e3-51e9-4ce9-a27d-717fa516ad52"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37b953e8-7184-469b-b7c4-046727254601"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c0ba71a-a48e-4475-9323-6ca37c53d3b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("41a966df-9a22-4c98-bfdc-47abd4ebafd2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f1a1348-4cfa-4cc8-9d67-c301991faf8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("569a90f0-570e-4ab7-bf4a-03939d7d17c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6101aea4-761d-421e-9092-78f1631690ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("656f7337-516e-4181-ad87-1917a5786c32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65d7745f-914e-47eb-bd82-bc0b36a3e4a2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7961a21e-6500-4bec-bc9d-c473a935c544"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("818d3459-ce46-4f26-bed3-fb78f6728011"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("902c0946-78d4-431e-a0b0-68cc0abfe8e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9381a751-de2d-4060-9016-36fdabaeca4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("94d1582d-ab08-44ed-a647-ef0666719a54"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d6aba5b-4083-4ce9-95c1-601a8cd45587"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e877aab-689d-4dff-9286-beafc3633783"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3b9b8de-5f77-4ebc-be58-a09c18a4f6a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a93fe4bc-4071-4330-a7c3-009ace461cf2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9e599bf-a156-4594-9e90-f179ee038ece"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aec7e15e-f189-4df5-a393-5c4bdbd7a1aa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af65aea9-6582-448b-b83e-15c7757a9352"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b358fbb0-f009-47d8-88a5-af1321d9dcef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b43d7087-fa4d-4895-ac8c-3b48b310c3ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be454965-1f5b-4319-a84b-58d3817653c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bfdab153-4491-49e2-87c5-7d8e65e5608e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c17aa89d-1adc-43b4-a836-d60cd53164b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c186247c-327c-448d-9d8e-033a3945b87f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4131ceb-8356-4508-b100-742f4bb6b8ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cce8d91d-d635-42ff-a16b-1d594a8f59a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d1c54add-d632-492b-b471-40eed825460f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d660adc8-c7aa-4dfb-856a-a1311822471e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6f0b258-80e7-44a3-8dc5-2ab0a59b3ca9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0661e7c-1c5d-4e92-8b09-86fbd5c6210c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e39f770f-507f-4d09-a297-14f6a4de46b1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ee9b974d-bd0d-4cee-8c21-c7c9fbbcbd4f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("0b88e63e-8f42-4ee1-8129-5ef023fc0690"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("0f66b685-6a36-44de-83f1-c8e89071b6c9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("11745ede-15c5-406a-b545-7e8b1e8421b0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("224a5b30-3778-4a27-82a8-c408c2e66f1e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("22c7ab65-5786-457c-a216-652af8026f42"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2ba780d3-5e77-48f8-a64e-7e634d068548"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2f150d2d-3e98-436d-9985-2765ac4b35de"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("3661acc2-10a3-4853-a1f8-51a0bb27334b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("366755a2-f5e5-45aa-9eab-8f9e61568def"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4091f85b-190f-41e9-ad6d-ad86c3c61662"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("45f0f402-6b29-49f8-8a38-a9c2b1ddfd31"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("51f12324-6a5a-4d4a-b012-523f573783ac"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("56c266c2-27a3-413f-be4f-2d9a48e65c95"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5dd3969e-9820-4d1c-a7a8-82de0f53dab9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5f72a04b-0174-42c7-8377-dc9206d0ac07"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6051bd2d-ac7c-4095-a4b5-d7692f24767a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("605d8aec-423b-4cc3-9134-0de3dcadc4a3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("61773b66-8079-4a70-b8f2-2d59355b5134"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("64e54316-089a-476d-94bd-da2e308631b7"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6b6980ec-a9bf-4aa3-bb09-ba7542a1cec4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6d3e03a4-6933-4a68-a252-90ffda91032f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6e62b446-10f0-47cf-bc95-4e73b64b5a4e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7051d4f1-7681-4837-8edc-52048aff0cac"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("70ac3b76-8f6a-4681-9335-0ad7b8a38ee1"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8b137b52-ba7e-4ad3-8716-e6ddc40460c1"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("95dab6cd-0fcd-4210-a4c8-098c87d9c7eb"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("97dbc922-0033-472e-9328-17d045789541"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a338a122-c49a-46b0-9350-dcae1a5dc300"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("aa8b9626-1e41-467a-b8a5-b6b1860fbdd3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b5580d2c-6021-4b44-846a-afc1675b25a7"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b9da573e-bb16-411d-8b51-7f4c56bf757e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("bda7d97e-ff94-4743-8762-6e233b2cfdad"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d58042c7-f3dd-4f35-afec-99bd1742d33a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d7613f1c-1db6-4edb-b5a2-aee798e00a03"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d958301e-2e7a-41bf-a683-82ff3e462adb"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("dd92b51b-6a0e-4f8c-8927-6162a9f643a9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e3376ff5-1145-49b7-bc23-1e9347e56f5b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e390a143-ef92-4571-ae75-d362c10566f6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e3a076da-e336-4309-89f0-df5d9f481a51"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e721dcff-90fc-429c-b88e-7751066dfbc3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("eb8d798e-c580-4aab-8ad6-4980817f4ecd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("efd7e48a-a780-4a2a-af56-63d100dcbcb0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f33c75aa-99c1-484b-9b99-1198e1076cc6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fd301574-e6ae-4856-8d17-7aaac7174613"));

            migrationBuilder.AddColumn<bool>(
                name: "IsSpotifyDj",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Currency", "Description", "Flag", "IsEUMember", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("ff095389-85e4-4b68-83e3-5aa35a6d5000"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("71f91e1f-bfd3-4495-8f3e-d8176dd89341"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("b5b986d5-558b-49df-a189-eb99486729b9"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("0b60e410-8947-43a9-a27b-c0a072ba98b9"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("c6cf96df-55f3-4667-9f55-d47a779edffd"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("b8160063-e119-42db-9de5-aa8aa160e53b"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("26119cde-6e26-42b6-b2f2-45eaecc421d9"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("579acad0-18cc-41d6-8889-dc7f975fd0f0"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("778bed60-fd3b-4127-9f64-1e90b74bda0a"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("f3cb4a7a-8962-4d71-88c5-ee73bd235807"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("958ac548-1e62-4540-ae30-e5f61178551f"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("ecd75e20-d565-4d20-980b-ab8124e02537"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("df3d92b9-c87c-4204-849a-e850a48bb14b"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("1ca0b16a-3050-407f-b5ca-c82774a18ab3"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("293af4d9-83db-4cf5-8824-94183b7c6209"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("99792ab3-97f1-4daa-bc48-8bf44ade1c4c"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("acc0e06f-f2ea-4c74-b65f-4296c27dc5da"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("8c8d6979-7afc-4066-88de-2cb1b81361f0"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("61f2c083-59aa-44c0-9aa8-fa4aea5659eb"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("60956897-bb06-4217-adc1-265bb1aad472"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("7c7d0b21-8d21-44af-aaa8-7a867dffe61d"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("1240b596-3a4f-4309-b99a-04651e20bc59"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("9e070662-b83c-43e2-bd5f-003d5e951d8d"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("64fb6c52-21c1-4e50-b558-165657fb2ef7"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("6c35f0b2-851a-41a1-84db-c931789fca24"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("b1a05ac0-8d75-44dd-b9b6-a531eab50052"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("4b634311-4b43-44f6-a61a-7ccec29b2052"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("7fe8be70-612e-460f-87fd-5d5aeb43113a"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L },
                    { new Guid("f542cad6-7b34-4f3f-8f61-84d9df7c95fe"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("bd486c08-75c1-46a6-9466-bb96d1ad9d64"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("1c48fd78-f07a-452f-848b-35b9e68dd51c"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("be0e3b02-c567-4f5d-aacf-a92c0f8cff2d"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("32bb5cb2-8723-43ea-8455-ab94589b3be3"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("d19d849d-9647-486d-9168-f8ca256b9d86"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("67925404-0abb-47ae-b3d5-27381468b72d"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("be78bc37-b733-4f1f-83d0-0de9db32800f"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("d715500b-e9c1-41e9-b6b5-78012843a693"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("b92444ef-cd6e-46df-8392-67d51609403b"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("98de07e3-37d7-41d4-8eca-dc437ddb34c8"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("077c87f3-e1a5-4c26-a6a2-cb8b14748984"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("7b5cd27e-d59c-4953-8c24-675c7e3f69db"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("6add9e02-db5d-4298-baf8-31183769f472"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("deaceef0-dda6-4fb4-ae10-fa9dc3e549d2"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("05229b50-f716-47fa-830b-d7bd4db78123"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("65061da4-00af-49b4-ae51-888572582dea"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("919b370e-7da9-4be5-b913-c1459f29b9ce"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("aa5f57f9-8366-4677-a51e-d24d366b1adb"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("15109661-3bb7-4ba2-b6d9-6b51318234a1"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("951ee1f8-8990-4b68-98e3-206b8d1a48a8"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("c93104cd-3629-4bce-b5de-91d5f26fe9a6"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("a9077b19-ab6c-4331-b5e4-35462b0a83c1"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("480f76b3-3923-4bcf-a5ab-a063a5d00c01"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("acc2ab1e-fd07-42e8-9691-1914959377cb"), new Guid("c6cf96df-55f3-4667-9f55-d47a779edffd"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("a9199c98-95c8-4e71-a9ef-cbac3d57ee64"), new Guid("1ca0b16a-3050-407f-b5ca-c82774a18ab3"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("bd614a2e-3a22-4023-8d13-ee132bccdc80"), new Guid("579acad0-18cc-41d6-8889-dc7f975fd0f0"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("465d4e4d-da41-42df-8d74-c58c05cf1cb4"), new Guid("778bed60-fd3b-4127-9f64-1e90b74bda0a"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("630d5cf1-af0a-46ef-a970-bb43fbab440f"), new Guid("f3cb4a7a-8962-4d71-88c5-ee73bd235807"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("9865638f-23d2-4354-b88a-d4bd77688db2"), new Guid("958ac548-1e62-4540-ae30-e5f61178551f"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("aca12ca3-2bf7-4843-ba5d-17bb436b75a8"), new Guid("ecd75e20-d565-4d20-980b-ab8124e02537"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("bc63d026-ffe9-4b43-8254-5acd586e77b1"), new Guid("df3d92b9-c87c-4204-849a-e850a48bb14b"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("df3f3fbf-dc8d-4349-89ad-b85d7789d990"), new Guid("26119cde-6e26-42b6-b2f2-45eaecc421d9"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("81c6eb3c-99b4-4e6c-a29e-1c2c3754660f"), new Guid("7c7d0b21-8d21-44af-aaa8-7a867dffe61d"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("3f3a0eaa-623f-45d2-839a-0746320b338e"), new Guid("99792ab3-97f1-4daa-bc48-8bf44ade1c4c"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("a879939b-8a2f-4e5e-ba53-273e2a1f357f"), new Guid("acc0e06f-f2ea-4c74-b65f-4296c27dc5da"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("bca5c345-5cf1-407e-8533-b7562b374e4d"), new Guid("8c8d6979-7afc-4066-88de-2cb1b81361f0"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("a636258c-e1bd-4909-b565-8d6bcad86819"), new Guid("61f2c083-59aa-44c0-9aa8-fa4aea5659eb"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("f88f881d-0e30-4405-9313-fc57b76a2ef2"), new Guid("4b634311-4b43-44f6-a61a-7ccec29b2052"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("1290fb25-5a79-4d27-bbae-763446a3d3bd"), new Guid("1240b596-3a4f-4309-b99a-04651e20bc59"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("d589adf2-ddcb-46f5-a2aa-1a8c4290fdad"), new Guid("9e070662-b83c-43e2-bd5f-003d5e951d8d"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("b3465e80-7af4-4e5b-a6eb-886dd0032560"), new Guid("64fb6c52-21c1-4e50-b558-165657fb2ef7"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("b9f0566d-9976-475e-a25f-08b5f24990bd"), new Guid("0b60e410-8947-43a9-a27b-c0a072ba98b9"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("a7a5a53c-2d48-4bb6-8d55-23463f5d2e20"), new Guid("00000000-0000-0000-0000-000000000001"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("67f9bf34-aaab-4a31-bff8-d90ecf5579a3"), new Guid("293af4d9-83db-4cf5-8824-94183b7c6209"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("b332516a-5075-4423-bfe4-36a400609567"), new Guid("b5b986d5-558b-49df-a189-eb99486729b9"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("e10ef82e-ecef-4ca8-98cb-06ca347ed34e"), new Guid("6add9e02-db5d-4298-baf8-31183769f472"), "1ObBKzabSHf6WD4VZI8fJU" },
                    { new Guid("1ac16656-82a2-4d80-b6b2-d7f82b37a914"), new Guid("7fe8be70-612e-460f-87fd-5d5aeb43113a"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("64c6714b-26ef-485f-ab91-0a4506338e75"), new Guid("ff095389-85e4-4b68-83e3-5aa35a6d5000"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("d05f142a-aabd-4841-a033-506c04a2654c"), new Guid("bd486c08-75c1-46a6-9466-bb96d1ad9d64"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("1ea1a829-b508-4b49-ac90-204c8551ca66"), new Guid("1c48fd78-f07a-452f-848b-35b9e68dd51c"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("ea6b4eb0-9016-45d3-8e5d-2b3514c9d512"), new Guid("be0e3b02-c567-4f5d-aacf-a92c0f8cff2d"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("1d0699fe-8e98-4d43-999d-31b5cb6c7f81"), new Guid("32bb5cb2-8723-43ea-8455-ab94589b3be3"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("475c632e-e9cf-4792-acab-ee79326f61ac"), new Guid("67925404-0abb-47ae-b3d5-27381468b72d"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("da8c248b-fb29-4eb8-b914-a329f00c57d0"), new Guid("be78bc37-b733-4f1f-83d0-0de9db32800f"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("be7b70a1-185d-40e5-bc08-9e907d83039a"), new Guid("d715500b-e9c1-41e9-b6b5-78012843a693"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("deb01dbd-3403-4a61-aa04-fd2d9ba8ef6b"), new Guid("f542cad6-7b34-4f3f-8f61-84d9df7c95fe"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("44414a5f-80e6-48ac-b2d0-ec77ebb8bf25"), new Guid("b92444ef-cd6e-46df-8392-67d51609403b"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("5f8d31c9-5c9b-46fc-8dae-e685f768d4cd"), new Guid("7b5cd27e-d59c-4953-8c24-675c7e3f69db"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("ee1f9439-25a2-4725-b477-c5342f734ff8"), new Guid("a9077b19-ab6c-4331-b5e4-35462b0a83c1"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("5e532476-7b1f-425f-83d2-a456876995d5"), new Guid("c93104cd-3629-4bce-b5de-91d5f26fe9a6"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("cf40bb28-53b3-494a-8a86-573d9a895ba3"), new Guid("951ee1f8-8990-4b68-98e3-206b8d1a48a8"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("d56399a3-b08d-446c-a27e-e4764b0c21cd"), new Guid("15109661-3bb7-4ba2-b6d9-6b51318234a1"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("e394d487-ad21-4ff5-b99c-e69f699146fa"), new Guid("480f76b3-3923-4bcf-a5ab-a063a5d00c01"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("62af718b-9d84-4905-ba4c-cb87aecc2373"), new Guid("05229b50-f716-47fa-830b-d7bd4db78123"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("48de1811-ad55-47ae-b353-58108f7c9188"), new Guid("deaceef0-dda6-4fb4-ae10-fa9dc3e549d2"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("67bb7dcb-d319-492a-887a-5e5ec37ca008"), new Guid("aa5f57f9-8366-4677-a51e-d24d366b1adb"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("5f04a517-632a-4ac1-bb3b-85e1f5638faa"), new Guid("98de07e3-37d7-41d4-8eca-dc437ddb34c8"), "7nUxZrzOz1FS67LYqsjdIv" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "IsSpotifyDj", "Password" },
                values: new object[] { true, "AQAAAAEAACcQAAAAEIq9Q40h/8d3Jn7fS8F6UI3FSp2jgipN52zEU6+MVlNhtMBYuU3QdO/q4uDHw3boAQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5311214-564f-4824-ba65-b57042349e49"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMsY/Y1jESnMYwYuxpAEkYIxkKf2CQ/fsMHinPut9xAjlih5Gy86jXTwta1q3qDMpg==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("05229b50-f716-47fa-830b-d7bd4db78123"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("077c87f3-e1a5-4c26-a6a2-cb8b14748984"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b60e410-8947-43a9-a27b-c0a072ba98b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1240b596-3a4f-4309-b99a-04651e20bc59"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15109661-3bb7-4ba2-b6d9-6b51318234a1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c48fd78-f07a-452f-848b-35b9e68dd51c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ca0b16a-3050-407f-b5ca-c82774a18ab3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("26119cde-6e26-42b6-b2f2-45eaecc421d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("293af4d9-83db-4cf5-8824-94183b7c6209"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32bb5cb2-8723-43ea-8455-ab94589b3be3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("480f76b3-3923-4bcf-a5ab-a063a5d00c01"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4b634311-4b43-44f6-a61a-7ccec29b2052"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("579acad0-18cc-41d6-8889-dc7f975fd0f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60956897-bb06-4217-adc1-265bb1aad472"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61f2c083-59aa-44c0-9aa8-fa4aea5659eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64fb6c52-21c1-4e50-b558-165657fb2ef7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65061da4-00af-49b4-ae51-888572582dea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67925404-0abb-47ae-b3d5-27381468b72d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6add9e02-db5d-4298-baf8-31183769f472"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6c35f0b2-851a-41a1-84db-c931789fca24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71f91e1f-bfd3-4495-8f3e-d8176dd89341"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("778bed60-fd3b-4127-9f64-1e90b74bda0a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b5cd27e-d59c-4953-8c24-675c7e3f69db"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7c7d0b21-8d21-44af-aaa8-7a867dffe61d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fe8be70-612e-460f-87fd-5d5aeb43113a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c8d6979-7afc-4066-88de-2cb1b81361f0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("919b370e-7da9-4be5-b913-c1459f29b9ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("951ee1f8-8990-4b68-98e3-206b8d1a48a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("958ac548-1e62-4540-ae30-e5f61178551f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98de07e3-37d7-41d4-8eca-dc437ddb34c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99792ab3-97f1-4daa-bc48-8bf44ade1c4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e070662-b83c-43e2-bd5f-003d5e951d8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a9077b19-ab6c-4331-b5e4-35462b0a83c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aa5f57f9-8366-4677-a51e-d24d366b1adb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("acc0e06f-f2ea-4c74-b65f-4296c27dc5da"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1a05ac0-8d75-44dd-b9b6-a531eab50052"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b5b986d5-558b-49df-a189-eb99486729b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8160063-e119-42db-9de5-aa8aa160e53b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b92444ef-cd6e-46df-8392-67d51609403b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd486c08-75c1-46a6-9466-bb96d1ad9d64"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be0e3b02-c567-4f5d-aacf-a92c0f8cff2d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be78bc37-b733-4f1f-83d0-0de9db32800f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6cf96df-55f3-4667-9f55-d47a779edffd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c93104cd-3629-4bce-b5de-91d5f26fe9a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d19d849d-9647-486d-9168-f8ca256b9d86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d715500b-e9c1-41e9-b6b5-78012843a693"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("deaceef0-dda6-4fb4-ae10-fa9dc3e549d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df3d92b9-c87c-4204-849a-e850a48bb14b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ecd75e20-d565-4d20-980b-ab8124e02537"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3cb4a7a-8962-4d71-88c5-ee73bd235807"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f542cad6-7b34-4f3f-8f61-84d9df7c95fe"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff095389-85e4-4b68-83e3-5aa35a6d5000"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1290fb25-5a79-4d27-bbae-763446a3d3bd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1ac16656-82a2-4d80-b6b2-d7f82b37a914"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1d0699fe-8e98-4d43-999d-31b5cb6c7f81"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1ea1a829-b508-4b49-ac90-204c8551ca66"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("3f3a0eaa-623f-45d2-839a-0746320b338e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("44414a5f-80e6-48ac-b2d0-ec77ebb8bf25"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("465d4e4d-da41-42df-8d74-c58c05cf1cb4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("475c632e-e9cf-4792-acab-ee79326f61ac"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("48de1811-ad55-47ae-b353-58108f7c9188"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5e532476-7b1f-425f-83d2-a456876995d5"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5f04a517-632a-4ac1-bb3b-85e1f5638faa"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5f8d31c9-5c9b-46fc-8dae-e685f768d4cd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("62af718b-9d84-4905-ba4c-cb87aecc2373"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("630d5cf1-af0a-46ef-a970-bb43fbab440f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("64c6714b-26ef-485f-ab91-0a4506338e75"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("67bb7dcb-d319-492a-887a-5e5ec37ca008"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("67f9bf34-aaab-4a31-bff8-d90ecf5579a3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("81c6eb3c-99b4-4e6c-a29e-1c2c3754660f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("9865638f-23d2-4354-b88a-d4bd77688db2"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a636258c-e1bd-4909-b565-8d6bcad86819"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a7a5a53c-2d48-4bb6-8d55-23463f5d2e20"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a879939b-8a2f-4e5e-ba53-273e2a1f357f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a9199c98-95c8-4e71-a9ef-cbac3d57ee64"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("aca12ca3-2bf7-4843-ba5d-17bb436b75a8"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("acc2ab1e-fd07-42e8-9691-1914959377cb"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b332516a-5075-4423-bfe4-36a400609567"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b3465e80-7af4-4e5b-a6eb-886dd0032560"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b9f0566d-9976-475e-a25f-08b5f24990bd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("bc63d026-ffe9-4b43-8254-5acd586e77b1"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("bca5c345-5cf1-407e-8533-b7562b374e4d"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("bd614a2e-3a22-4023-8d13-ee132bccdc80"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("be7b70a1-185d-40e5-bc08-9e907d83039a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("cf40bb28-53b3-494a-8a86-573d9a895ba3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d05f142a-aabd-4841-a033-506c04a2654c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d56399a3-b08d-446c-a27e-e4764b0c21cd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d589adf2-ddcb-46f5-a2aa-1a8c4290fdad"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("da8c248b-fb29-4eb8-b914-a329f00c57d0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("deb01dbd-3403-4a61-aa04-fd2d9ba8ef6b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("df3f3fbf-dc8d-4349-89ad-b85d7789d990"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e10ef82e-ecef-4ca8-98cb-06ca347ed34e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e394d487-ad21-4ff5-b99c-e69f699146fa"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ea6b4eb0-9016-45d3-8e5d-2b3514c9d512"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ee1f9439-25a2-4725-b477-c5342f734ff8"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f88f881d-0e30-4405-9313-fc57b76a2ef2"));

            migrationBuilder.DropColumn(
                name: "IsSpotifyDj",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Currency", "Description", "Flag", "IsEUMember", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("e0661e7c-1c5d-4e92-8b09-86fbd5c6210c"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("37b953e8-7184-469b-b7c4-046727254601"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("b358fbb0-f009-47d8-88a5-af1321d9dcef"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("28d64068-3008-4dc4-91c4-475508b141e9"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("aec7e15e-f189-4df5-a393-5c4bdbd7a1aa"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("d6f0b258-80e7-44a3-8dc5-2ab0a59b3ca9"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("4f1a1348-4cfa-4cc8-9d67-c301991faf8e"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("c186247c-327c-448d-9d8e-033a3945b87f"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("e39f770f-507f-4d09-a297-14f6a4de46b1"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("a9e599bf-a156-4594-9e90-f179ee038ece"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("317525e3-51e9-4ce9-a27d-717fa516ad52"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("6101aea4-761d-421e-9092-78f1631690ef"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("b43d7087-fa4d-4895-ac8c-3b48b310c3ba"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("af65aea9-6582-448b-b83e-15c7757a9352"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("ee9b974d-bd0d-4cee-8c21-c7c9fbbcbd4f"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("c4131ceb-8356-4508-b100-742f4bb6b8ad"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("9381a751-de2d-4060-9016-36fdabaeca4c"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("29b60e4b-e25d-453f-9708-38179c7c4a63"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("902c0946-78d4-431e-a0b0-68cc0abfe8e6"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("142bc481-3ed9-4fd1-8a1a-0ca7f3f3cca1"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("15d78f70-6b9b-4bf6-8028-a1586991af67"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("0c6193a3-9e55-4bf9-ad4a-a78b6ebd1386"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("0e8c8f29-9f39-491a-94fc-5288204fe9ae"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("18f5651a-8749-4793-a3fd-15e9920f2a65"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("41a966df-9a22-4c98-bfdc-47abd4ebafd2"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("cce8d91d-d635-42ff-a16b-1d594a8f59a7"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("65d7745f-914e-47eb-bd82-bc0b36a3e4a2"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("044f3e1a-a5df-495e-8f01-f8bd2caf7615"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L },
                    { new Guid("1632e94b-8d85-4059-95de-031dfd29487c"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("569a90f0-570e-4ab7-bf4a-03939d7d17c1"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("25c815a4-e84b-4785-ad20-da974dd3391e"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("94d1582d-ab08-44ed-a647-ef0666719a54"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("7961a21e-6500-4bec-bc9d-c473a935c544"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("a93fe4bc-4071-4330-a7c3-009ace461cf2"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("3c0ba71a-a48e-4475-9323-6ca37c53d3b6"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("0592b07e-a077-4bd2-a69d-abbb59894b3a"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("9e877aab-689d-4dff-9286-beafc3633783"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("2026c7e7-f6bb-4827-9a2b-825a29c10929"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("a3b9b8de-5f77-4ebc-be58-a09c18a4f6a7"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("c17aa89d-1adc-43b4-a836-d60cd53164b4"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("0e0e745c-a00d-45db-a869-c27618e6d3ca"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("00d81e42-04d3-43dd-b6b3-4ec42cd80497"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("be454965-1f5b-4319-a84b-58d3817653c8"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("656f7337-516e-4181-ad87-1917a5786c32"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("2cec81d5-65af-47e1-b328-37b81fe5fd16"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("d660adc8-c7aa-4dfb-856a-a1311822471e"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("07ff30e1-ab00-45de-b057-8ae2e412b242"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("9d6aba5b-4083-4ce9-95c1-601a8cd45587"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("1e980c3f-1cfe-4e5c-a4e5-7da736dda998"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("d1c54add-d632-492b-b471-40eed825460f"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("818d3459-ce46-4f26-bed3-fb78f6728011"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("bfdab153-4491-49e2-87c5-7d8e65e5608e"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("22c7ab65-5786-457c-a216-652af8026f42"), new Guid("aec7e15e-f189-4df5-a393-5c4bdbd7a1aa"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("b5580d2c-6021-4b44-846a-afc1675b25a7"), new Guid("af65aea9-6582-448b-b83e-15c7757a9352"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("51f12324-6a5a-4d4a-b012-523f573783ac"), new Guid("c186247c-327c-448d-9d8e-033a3945b87f"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("8b137b52-ba7e-4ad3-8716-e6ddc40460c1"), new Guid("e39f770f-507f-4d09-a297-14f6a4de46b1"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("eb8d798e-c580-4aab-8ad6-4980817f4ecd"), new Guid("a9e599bf-a156-4594-9e90-f179ee038ece"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("e721dcff-90fc-429c-b88e-7751066dfbc3"), new Guid("317525e3-51e9-4ce9-a27d-717fa516ad52"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("2f150d2d-3e98-436d-9985-2765ac4b35de"), new Guid("6101aea4-761d-421e-9092-78f1631690ef"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("97dbc922-0033-472e-9328-17d045789541"), new Guid("b43d7087-fa4d-4895-ac8c-3b48b310c3ba"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("61773b66-8079-4a70-b8f2-2d59355b5134"), new Guid("4f1a1348-4cfa-4cc8-9d67-c301991faf8e"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("d7613f1c-1db6-4edb-b5a2-aee798e00a03"), new Guid("15d78f70-6b9b-4bf6-8028-a1586991af67"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("6e62b446-10f0-47cf-bc95-4e73b64b5a4e"), new Guid("c4131ceb-8356-4508-b100-742f4bb6b8ad"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("45f0f402-6b29-49f8-8a38-a9c2b1ddfd31"), new Guid("9381a751-de2d-4060-9016-36fdabaeca4c"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("7051d4f1-7681-4837-8edc-52048aff0cac"), new Guid("29b60e4b-e25d-453f-9708-38179c7c4a63"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("e3a076da-e336-4309-89f0-df5d9f481a51"), new Guid("902c0946-78d4-431e-a0b0-68cc0abfe8e6"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("605d8aec-423b-4cc3-9134-0de3dcadc4a3"), new Guid("65d7745f-914e-47eb-bd82-bc0b36a3e4a2"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("bda7d97e-ff94-4743-8762-6e233b2cfdad"), new Guid("0c6193a3-9e55-4bf9-ad4a-a78b6ebd1386"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("224a5b30-3778-4a27-82a8-c408c2e66f1e"), new Guid("0e8c8f29-9f39-491a-94fc-5288204fe9ae"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("70ac3b76-8f6a-4681-9335-0ad7b8a38ee1"), new Guid("18f5651a-8749-4793-a3fd-15e9920f2a65"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("5dd3969e-9820-4d1c-a7a8-82de0f53dab9"), new Guid("28d64068-3008-4dc4-91c4-475508b141e9"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("64e54316-089a-476d-94bd-da2e308631b7"), new Guid("00000000-0000-0000-0000-000000000001"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("b9da573e-bb16-411d-8b51-7f4c56bf757e"), new Guid("ee9b974d-bd0d-4cee-8c21-c7c9fbbcbd4f"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("d958301e-2e7a-41bf-a683-82ff3e462adb"), new Guid("b358fbb0-f009-47d8-88a5-af1321d9dcef"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("366755a2-f5e5-45aa-9eab-8f9e61568def"), new Guid("00d81e42-04d3-43dd-b6b3-4ec42cd80497"), "1ObBKzabSHf6WD4VZI8fJU" },
                    { new Guid("6d3e03a4-6933-4a68-a252-90ffda91032f"), new Guid("044f3e1a-a5df-495e-8f01-f8bd2caf7615"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("5f72a04b-0174-42c7-8377-dc9206d0ac07"), new Guid("e0661e7c-1c5d-4e92-8b09-86fbd5c6210c"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("6b6980ec-a9bf-4aa3-bb09-ba7542a1cec4"), new Guid("569a90f0-570e-4ab7-bf4a-03939d7d17c1"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("0f66b685-6a36-44de-83f1-c8e89071b6c9"), new Guid("25c815a4-e84b-4785-ad20-da974dd3391e"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("0b88e63e-8f42-4ee1-8129-5ef023fc0690"), new Guid("94d1582d-ab08-44ed-a647-ef0666719a54"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("f33c75aa-99c1-484b-9b99-1198e1076cc6"), new Guid("7961a21e-6500-4bec-bc9d-c473a935c544"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("6051bd2d-ac7c-4095-a4b5-d7692f24767a"), new Guid("3c0ba71a-a48e-4475-9323-6ca37c53d3b6"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("fd301574-e6ae-4856-8d17-7aaac7174613"), new Guid("0592b07e-a077-4bd2-a69d-abbb59894b3a"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("aa8b9626-1e41-467a-b8a5-b6b1860fbdd3"), new Guid("9e877aab-689d-4dff-9286-beafc3633783"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("3661acc2-10a3-4853-a1f8-51a0bb27334b"), new Guid("1632e94b-8d85-4059-95de-031dfd29487c"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("95dab6cd-0fcd-4210-a4c8-098c87d9c7eb"), new Guid("2026c7e7-f6bb-4827-9a2b-825a29c10929"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("11745ede-15c5-406a-b545-7e8b1e8421b0"), new Guid("0e0e745c-a00d-45db-a869-c27618e6d3ca"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("a338a122-c49a-46b0-9350-dcae1a5dc300"), new Guid("818d3459-ce46-4f26-bed3-fb78f6728011"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("d58042c7-f3dd-4f35-afec-99bd1742d33a"), new Guid("d1c54add-d632-492b-b471-40eed825460f"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("efd7e48a-a780-4a2a-af56-63d100dcbcb0"), new Guid("1e980c3f-1cfe-4e5c-a4e5-7da736dda998"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("e3376ff5-1145-49b7-bc23-1e9347e56f5b"), new Guid("9d6aba5b-4083-4ce9-95c1-601a8cd45587"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("dd92b51b-6a0e-4f8c-8927-6162a9f643a9"), new Guid("bfdab153-4491-49e2-87c5-7d8e65e5608e"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("4091f85b-190f-41e9-ad6d-ad86c3c61662"), new Guid("656f7337-516e-4181-ad87-1917a5786c32"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("2ba780d3-5e77-48f8-a64e-7e634d068548"), new Guid("be454965-1f5b-4319-a84b-58d3817653c8"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("e390a143-ef92-4571-ae75-d362c10566f6"), new Guid("07ff30e1-ab00-45de-b057-8ae2e412b242"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("56c266c2-27a3-413f-be4f-2d9a48e65c95"), new Guid("a3b9b8de-5f77-4ebc-be58-a09c18a4f6a7"), "7nUxZrzOz1FS67LYqsjdIv" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEIIy8cVsL7fM4mjtFTz1XYIT6z3F3CxjPYegDqJHLLCCNle36QZKHTJajebQT8YFRw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5311214-564f-4824-ba65-b57042349e49"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAO3oAUu4nc78NAXo9i+5+VEg+gdGF+qktiO1OVtqyHYnRVFb1uwcxo4TiydfRBZ3A==");
        }
    }
}
