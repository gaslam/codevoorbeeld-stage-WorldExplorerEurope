﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldExplorerEurope.API.Migrations
{
    public partial class SchangeFavouritesWishlistsAndMemories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavourites_Users_UserId",
                table: "UserFavourites");

            migrationBuilder.DropTable(
                name: "UserMemories");

            migrationBuilder.DropTable(
                name: "UserWishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFavourites",
                table: "UserFavourites");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("006389d7-3332-488e-9283-7a3837236ca3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00b217c4-d5fe-4ba4-a6d4-4adbbce89c21"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0bc6b7d1-81bd-42d7-91de-a5996daf58d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0eb64394-8934-4cb1-b8dc-545db1f2f6d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f0f5b09-2885-49a4-b463-5e33ac46078c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13f78068-d8bc-43c6-8ee2-c2e51dc6e22f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17d46766-0957-49de-b503-faa3aedcdc0b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18b1c9d4-0f46-468b-bae6-efb8ece8493f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c6c397d-f3ba-41a7-826c-d825bf80d989"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("301daf60-3c4b-4647-ac4f-0e9975fd3a5f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3b93944b-1ec4-4fa8-9450-fa377e0a46c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ee128df-0316-4449-88f0-3509319bcb69"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43b0d967-7b72-43c6-b2b0-f770d00654dc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48dcdb4d-656f-46f8-af7c-b470c4040207"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4afaade2-803d-4bac-a20d-fe04bbada748"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("554eeef7-39c4-4137-a896-478f6570071d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56755ca3-abed-4d88-8548-d14f9caa6994"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5dad1dc0-7a40-49cf-bcbe-8fa78286a2e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5e91347b-4503-422d-b51a-8639d80ee524"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6113820b-48cf-4ca7-8d81-62cbb46ca8f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6187be63-3274-4294-ae60-97418bad1797"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61f46a49-7295-4ca0-a3e3-04429f786a42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("633bfb34-56b4-47bc-bb4c-16c29d88d75e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63951e6c-c390-405c-a5c6-0862a1a03b21"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("681ea527-7571-401b-8272-33705b36dfea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e004184-34cf-40b5-8a88-5e8be5cbe701"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("744202f1-a504-42a8-9bfb-0b75e940d325"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78ba428a-9243-4cbc-b968-cf0718f93f59"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("859ca0ec-9596-402d-9772-43630beaf6f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87b802aa-b587-4a52-a85d-b987ea999db8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b240215-9acd-46aa-93d5-28319c629334"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d93fc42-52e4-4494-852c-2c5020f87203"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e5cc4fe-fe12-43e9-ab01-bcad4ddc4bf1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ec2f9ba-bbf2-4872-85ee-01e2b62d9df9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a02d71a7-723d-473c-8a28-1adcd537b6c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a75cb0d0-3486-481b-b01e-f7f3c538ce60"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b380f009-b30b-4bc6-8336-7ad4ad48ccc9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b96283a4-6f74-4908-a72f-b5bd1f6b915e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0f3780e-c9c7-4190-8cc5-e5a68b78a804"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8a726d9-9fbf-47d7-aaec-c2b7f70e5249"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cfa9c639-eaf9-484c-8649-d8c0b220a5eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d417fdf9-4124-4c0e-b407-481f10c77360"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9b1e4c4-4bc6-4244-9056-39e4a5727bc9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dae63c77-e849-4a2b-95a4-f72c92852997"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e177332f-a6e2-4872-97ac-ebf8eb0e0542"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1951415-5e6a-4432-bf84-79cd3db36a1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e2b86f3f-5662-4e18-9219-fa60b4c5198a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e4e7aec2-cede-4fb3-9f69-d53f9a419654"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eacce2b9-6ced-4c67-aab6-07682d934225"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f718505a-8535-4db8-801d-a1515c19671c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f99e3d26-9662-4cb1-97d8-de9389cbe57a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faff63e5-1d59-499a-a056-88922841178b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc0b59dd-0128-4d19-a4a1-2c8e4118e52e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("008dd53b-7911-497c-9569-48e852e4c677"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("05f89d22-e6cb-416d-85a3-a6cd0d353dba"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("08666394-43d0-4279-9eef-874035430b04"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("0f75ea5e-795e-4b22-b92f-3adceaa1c320"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("0f891b61-13ec-44ba-be00-70a57b20024c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("199ce7c9-1837-4135-91e5-185a8b0c2b47"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("26cbef6c-0b21-4cd1-85dc-61d66692963c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2a0fa61d-0438-4534-b891-30905372f7e7"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2baa4653-3e9f-4877-92ae-f9fa26bb9774"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2dc573a6-59de-4c86-bb13-b3d4eb958060"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2f278159-2801-4afe-83ae-432f354296da"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("32eaf261-33ad-45fb-a59e-aa1803bdd403"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("35827e3f-fdd9-4049-a75e-94a57d32744e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("37f728d3-1ec7-487c-8d64-0ec5c47a9ea0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("3f234a3a-9e04-45d8-80b1-ada1835fd765"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4090830a-c80c-4722-a096-7c942f35681e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("41d1990d-5786-498b-8d2b-e130ccef3324"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4b7c2773-4236-4815-afa6-5ac84919489e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4bcdfadc-bca2-45dc-bc48-fc237b4125f3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5cfa3ad3-6693-4e75-b919-d3e5677a5619"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5eaa718e-3f74-4559-819e-dba75bc939f7"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6bd7eec0-134c-46b7-9336-c2e3aea7bfe9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("755e52a9-73ec-4e84-bd58-e19a9173fb6c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("76b00b8a-fa58-4562-98a4-67a801fa60fb"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7bc500b8-21b1-4dd7-b9a0-0f7a596c062d"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("80751467-160d-4732-a29b-6ade1021a430"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("82ee6c24-33d5-4ae2-bd3a-ca14f4674c24"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8cfb5a67-52f3-4522-a44e-48fd558ec8ed"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("921bc83a-b70b-4a65-beaa-96c9978924f9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("9d0946aa-ad88-45f4-a1f8-95a5daf43eac"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a5596a89-7235-42e3-be2e-64b79153bd00"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a800ac13-c131-4749-8f16-c7626fe5a17a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("aa198753-7190-4206-974b-ccf2f62c0edf"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ac2c7f12-060a-40b3-a2c6-4a4b43eb0072"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("acdf0633-1131-41cf-817c-fffe99a82c49"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b3f4abc5-dea4-419f-a7d9-fafe955428e6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c50426ce-9c04-462a-bde3-c9b8b5281349"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c9fba597-fe3a-40ad-95f1-2c5730014b59"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d2069940-55c0-4f99-9429-43d01926972a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("df4e0761-a582-4a60-a73c-dda956b15c13"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e1a041c9-c4a1-4260-bdbc-17f38ca1b808"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e52a8f01-39e8-44ce-94ef-ca623767c42c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fbac21b1-ab26-4c33-b202-5c3e09fc58de"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fda4464e-be0f-40d0-b5df-2bf709c16651"));

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserFavourites");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Memories");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Favourites");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Wishlists",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "UserFavourites",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Memories",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Favourites",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFavourites",
                table: "UserFavourites",
                columns: new[] { "CountryId", "FavouriteId" });

            migrationBuilder.CreateTable(
                name: "CountryMemories",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(nullable: false),
                    MemoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMemories", x => new { x.CountryId, x.MemoryId });
                    table.ForeignKey(
                        name: "FK_CountryMemories_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryMemories_Memories_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryWishlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CountryId = table.Column<Guid>(nullable: false),
                    WishlistId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryWishlists", x => x.Id);
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
                    { new Guid("720a28d4-07c3-4583-8170-d04ea715f4ca"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("3ab36535-e18e-4d99-b7d3-4b58eda83229"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("a564c0b9-1609-45a2-985b-a1c3eef9a1c9"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("d9203d92-f1fc-480b-b7c2-e97701071292"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("e7cf3e6d-6f9f-4c61-8be8-c9bf0720ac39"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("e3af41e6-0bd6-4de9-882d-204a53533aaa"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("1c4fa622-48d9-4142-994c-eeca4a117601"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("56893796-4bbf-4737-b298-bdc4f371212a"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("c4acc698-91e5-4944-87f6-189cabf811c4"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("9fd7cddd-74d5-43a8-a13d-363c846e1893"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("0990e14e-a6b4-41f5-9605-a99428c3c31b"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("ddf06216-9556-4fe3-a720-f2bb5b80a389"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("12d34d54-f40f-406d-a0ff-3a6c8504ef78"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("fe26950c-b469-4bf8-a8f4-b95ed535d31c"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("4f097082-28d4-4524-8dcf-cee10c8e9d58"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("a0ce34c4-2491-49f4-8228-b3750fadbf81"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("361e33f5-97a8-4ca9-83f3-bb696f2f9ed4"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("4c3a8238-188e-495d-9a35-2324a5223519"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("40837ebb-24c1-4d69-80d3-045c9dfd85eb"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("0d12dba0-e6d8-405b-8899-11b2ed94f340"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("70d601d9-d5a6-489d-86cf-2b9c803b17f3"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("b964575b-bf57-4619-8f75-f32857997aa7"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("5dc60bd4-f2df-4435-8f5a-55df0a8d5eb4"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("590a89e3-22b4-4167-8e3c-a896337e7525"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("d75181f4-8d08-47f2-8b81-54d59b0c3c1d"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("21f2c9bd-2343-40be-97d6-5b26d88b4a13"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("700c825d-c006-4d03-93a1-ce7929ac7a28"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("4a1244bb-2f93-40b8-b244-615d31e8d35f"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("e7dc660f-90cf-49fe-8b93-e16c7caee378"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("4f760d83-36b9-4840-a6ee-cefd79897a6d"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("e47dfc62-ec03-4e14-a521-85c286092187"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("6e2414cd-608b-4eab-81c2-9920a3c0d055"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("69a8b674-ab43-41e4-8fff-a9fbed506f30"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("3885d39f-82b7-4323-b3e9-941a11503cf9"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("b7c19c8e-296b-403d-b92c-f11c198395eb"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("9b04c73d-fb61-49ea-840d-ad739a22e95b"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("4d5da253-5dca-46d5-af07-0de846b60ff5"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("3793b091-bd0c-4335-89e2-fb974d7798b6"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("8ed96896-8030-49e8-bd56-30f6855ae00e"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("a3ddd305-20bd-4468-8236-f41952db2b2a"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("b56e9b29-a89b-4dd1-b11d-9acca39a8bc7"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("73cd294f-d8a2-4054-93a4-98698579bb45"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("5fa42f2e-204d-417a-b356-4f97b8880eb8"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("4374da63-39f5-4dcf-8d37-33f062ae3d07"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("e8686a82-c068-487e-8a02-6afb85153234"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("0c98804b-1594-452f-94dc-904401bd28f6"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("4f082482-49a9-4b1c-a71f-8b1e8e392b32"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("c6fbd334-c4ca-4fa0-88b3-246f3a7c26c2"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("12950b5e-2297-462a-b2d0-59bc1eb811f1"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("04ac1990-265c-4b64-8786-8283c9d8418b"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("fcbb5a98-a7f3-45e7-b923-bd7cfbe09eca"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("ac070deb-380d-4059-81d8-2b33ee354002"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("1946b51a-5ac6-4dcc-acab-b923f9477023"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("9dc5b19a-ccf1-43bd-882d-d2bea0214088"), new Guid("d9203d92-f1fc-480b-b7c2-e97701071292"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("2dc65c68-b2cf-447e-a1ed-2366f3be932e"), new Guid("e3af41e6-0bd6-4de9-882d-204a53533aaa"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("8f8775be-ef62-4913-8cef-195cb8aaa03c"), new Guid("12d34d54-f40f-406d-a0ff-3a6c8504ef78"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("70811f65-563f-4fe9-b7db-28029f67cce0"), new Guid("1c4fa622-48d9-4142-994c-eeca4a117601"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("decdd898-f86c-412b-93a4-e7e01acacd08"), new Guid("56893796-4bbf-4737-b298-bdc4f371212a"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("e5923b9e-8be8-46d7-b9fd-bbfa1021d118"), new Guid("c4acc698-91e5-4944-87f6-189cabf811c4"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("e0c88896-da45-43ca-8ff8-7e900af48b65"), new Guid("9fd7cddd-74d5-43a8-a13d-363c846e1893"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("4c9b43ea-bdbb-4b97-9a78-3025d0c081c8"), new Guid("0990e14e-a6b4-41f5-9605-a99428c3c31b"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("ddd24e8c-6b0a-4e36-8850-c9f31750a096"), new Guid("ddf06216-9556-4fe3-a720-f2bb5b80a389"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("5d213902-7496-4e07-9898-7d82231f8339"), new Guid("4c3a8238-188e-495d-9a35-2324a5223519"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("f74f22f7-039b-45f8-a1ee-3ffc19f734ce"), new Guid("4f097082-28d4-4524-8dcf-cee10c8e9d58"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("c9de76d6-cdc2-45b8-81d6-e71e50747d9f"), new Guid("a0ce34c4-2491-49f4-8228-b3750fadbf81"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("e2d2e104-89a2-4fe9-97c6-7963552e43ac"), new Guid("361e33f5-97a8-4ca9-83f3-bb696f2f9ed4"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("533f8bb8-d3e5-4dcb-b3cc-4df7fe7862a7"), new Guid("0d12dba0-e6d8-405b-8899-11b2ed94f340"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("a4db92e6-e09d-448e-923c-828633ef967f"), new Guid("700c825d-c006-4d03-93a1-ce7929ac7a28"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("da44d172-a50a-491b-a6a9-d69b779d1e7b"), new Guid("70d601d9-d5a6-489d-86cf-2b9c803b17f3"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("8cd33cee-7375-4934-8a22-d873097ac929"), new Guid("b964575b-bf57-4619-8f75-f32857997aa7"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("d73a89ce-e002-473c-a76f-1127984bf25f"), new Guid("a564c0b9-1609-45a2-985b-a1c3eef9a1c9"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("dfce02fa-0404-4022-97d2-3a6dc05f693b"), new Guid("5dc60bd4-f2df-4435-8f5a-55df0a8d5eb4"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("6a1e53a1-ad9a-4773-897e-d993723eb41b"), new Guid("fe26950c-b469-4bf8-a8f4-b95ed535d31c"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("628363ff-8842-45a0-b9e9-aa0a6a2bc00e"), new Guid("3ab36535-e18e-4d99-b7d3-4b58eda83229"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("0fd50c47-06cf-413d-99c7-8c969d7514eb"), new Guid("8ed96896-8030-49e8-bd56-30f6855ae00e"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("e8f9ea64-3f5e-4bd3-a1d8-ad34af287e03"), new Guid("1946b51a-5ac6-4dcc-acab-b923f9477023"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("a9fbf6cb-7229-4c69-8f37-9123694b96e6"), new Guid("590a89e3-22b4-4167-8e3c-a896337e7525"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("c77d7c7c-d91f-4122-8bd2-a7aae3ee6497"), new Guid("720a28d4-07c3-4583-8170-d04ea715f4ca"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("e20e9efe-ac0f-4d42-8d5f-e69dce5e5316"), new Guid("4f760d83-36b9-4840-a6ee-cefd79897a6d"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("e2d6b460-21b1-4173-8735-78af8e43e84d"), new Guid("b56e9b29-a89b-4dd1-b11d-9acca39a8bc7"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("6bc03f53-8029-4ffb-acf4-d1e446eef7b3"), new Guid("6e2414cd-608b-4eab-81c2-9920a3c0d055"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("2e0e3eb3-6963-49e5-a3e1-f339c73d0c02"), new Guid("69a8b674-ab43-41e4-8fff-a9fbed506f30"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("a1545bfe-ef91-4e3c-a7f0-82a144b2dd5e"), new Guid("b7c19c8e-296b-403d-b92c-f11c198395eb"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("fef81267-71c8-43ec-bc6f-c28ebf3cf635"), new Guid("9b04c73d-fb61-49ea-840d-ad739a22e95b"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("3a9f9874-6e87-4bbf-849f-f21b5f1df536"), new Guid("4d5da253-5dca-46d5-af07-0de846b60ff5"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("66371e37-59ba-45d4-9afd-7d543c3fde89"), new Guid("4a1244bb-2f93-40b8-b244-615d31e8d35f"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("7aaeb000-aa49-4ef8-958f-0b00fba639f9"), new Guid("3793b091-bd0c-4335-89e2-fb974d7798b6"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("363904a2-2437-4f9f-9a64-94c20fdb943f"), new Guid("5fa42f2e-204d-417a-b356-4f97b8880eb8"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("510c8654-1b21-4479-8c6a-863f90372ac6"), new Guid("73cd294f-d8a2-4054-93a4-98698579bb45"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("6d8cb999-b260-45b1-8a1e-4e326df57597"), new Guid("fcbb5a98-a7f3-45e7-b923-bd7cfbe09eca"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("1950b2e4-e474-4e81-b2f7-445c1f339583"), new Guid("04ac1990-265c-4b64-8786-8283c9d8418b"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("736fc751-2c55-4a91-962c-82c442710ba9"), new Guid("12950b5e-2297-462a-b2d0-59bc1eb811f1"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("e793f69c-174c-4ae0-84ee-cc93c3b95ec1"), new Guid("c6fbd334-c4ca-4fa0-88b3-246f3a7c26c2"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("02f19285-a0be-4c30-b2fe-7671ee18cbbf"), new Guid("e8686a82-c068-487e-8a02-6afb85153234"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("dfaab0a4-7665-4abc-9a3f-15dfc0ec9c93"), new Guid("4f082482-49a9-4b1c-a71f-8b1e8e392b32"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("b4ab8f67-9c96-4c6f-bca1-f54090591634"), new Guid("4374da63-39f5-4dcf-8d37-33f062ae3d07"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("941010b8-7114-4e04-b699-fab0f9d5ba0a"), new Guid("a3ddd305-20bd-4468-8236-f41952db2b2a"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5311214-564f-4824-ba65-b57042349e49"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAjKQIK4SZasLq2+s3FqmYDdj1tO5FphAHY60C1f5ycV4y2k3LwaWyD+QP6kAfoLgA==");

            migrationBuilder.CreateIndex(
                name: "IX_CountryMemories_MemoryId",
                table: "CountryMemories",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryWishlists_CountryId",
                table: "CountryWishlists",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryWishlists_WishlistId",
                table: "CountryWishlists",
                column: "WishlistId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavourites_Countries_CountryId",
                table: "UserFavourites",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavourites_Countries_CountryId",
                table: "UserFavourites");

            migrationBuilder.DropTable(
                name: "CountryMemories");

            migrationBuilder.DropTable(
                name: "CountryWishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFavourites",
                table: "UserFavourites");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04ac1990-265c-4b64-8786-8283c9d8418b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0990e14e-a6b4-41f5-9605-a99428c3c31b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c98804b-1594-452f-94dc-904401bd28f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0d12dba0-e6d8-405b-8899-11b2ed94f340"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12950b5e-2297-462a-b2d0-59bc1eb811f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12d34d54-f40f-406d-a0ff-3a6c8504ef78"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1946b51a-5ac6-4dcc-acab-b923f9477023"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c4fa622-48d9-4142-994c-eeca4a117601"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21f2c9bd-2343-40be-97d6-5b26d88b4a13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("361e33f5-97a8-4ca9-83f3-bb696f2f9ed4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3793b091-bd0c-4335-89e2-fb974d7798b6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3885d39f-82b7-4323-b3e9-941a11503cf9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ab36535-e18e-4d99-b7d3-4b58eda83229"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("40837ebb-24c1-4d69-80d3-045c9dfd85eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4374da63-39f5-4dcf-8d37-33f062ae3d07"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a1244bb-2f93-40b8-b244-615d31e8d35f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c3a8238-188e-495d-9a35-2324a5223519"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4d5da253-5dca-46d5-af07-0de846b60ff5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f082482-49a9-4b1c-a71f-8b1e8e392b32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f097082-28d4-4524-8dcf-cee10c8e9d58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f760d83-36b9-4840-a6ee-cefd79897a6d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("56893796-4bbf-4737-b298-bdc4f371212a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("590a89e3-22b4-4167-8e3c-a896337e7525"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5dc60bd4-f2df-4435-8f5a-55df0a8d5eb4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5fa42f2e-204d-417a-b356-4f97b8880eb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69a8b674-ab43-41e4-8fff-a9fbed506f30"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e2414cd-608b-4eab-81c2-9920a3c0d055"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("700c825d-c006-4d03-93a1-ce7929ac7a28"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70d601d9-d5a6-489d-86cf-2b9c803b17f3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("720a28d4-07c3-4583-8170-d04ea715f4ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73cd294f-d8a2-4054-93a4-98698579bb45"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ed96896-8030-49e8-bd56-30f6855ae00e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b04c73d-fb61-49ea-840d-ad739a22e95b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9fd7cddd-74d5-43a8-a13d-363c846e1893"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a0ce34c4-2491-49f4-8228-b3750fadbf81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3ddd305-20bd-4468-8236-f41952db2b2a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a564c0b9-1609-45a2-985b-a1c3eef9a1c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ac070deb-380d-4059-81d8-2b33ee354002"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b56e9b29-a89b-4dd1-b11d-9acca39a8bc7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b7c19c8e-296b-403d-b92c-f11c198395eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b964575b-bf57-4619-8f75-f32857997aa7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c4acc698-91e5-4944-87f6-189cabf811c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6fbd334-c4ca-4fa0-88b3-246f3a7c26c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d75181f4-8d08-47f2-8b81-54d59b0c3c1d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d9203d92-f1fc-480b-b7c2-e97701071292"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddf06216-9556-4fe3-a720-f2bb5b80a389"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e3af41e6-0bd6-4de9-882d-204a53533aaa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e47dfc62-ec03-4e14-a521-85c286092187"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7cf3e6d-6f9f-4c61-8be8-c9bf0720ac39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7dc660f-90cf-49fe-8b93-e16c7caee378"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8686a82-c068-487e-8a02-6afb85153234"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fcbb5a98-a7f3-45e7-b923-bd7cfbe09eca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe26950c-b469-4bf8-a8f4-b95ed535d31c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("02f19285-a0be-4c30-b2fe-7671ee18cbbf"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("0fd50c47-06cf-413d-99c7-8c969d7514eb"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1950b2e4-e474-4e81-b2f7-445c1f339583"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2dc65c68-b2cf-447e-a1ed-2366f3be932e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2e0e3eb3-6963-49e5-a3e1-f339c73d0c02"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("363904a2-2437-4f9f-9a64-94c20fdb943f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("3a9f9874-6e87-4bbf-849f-f21b5f1df536"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4c9b43ea-bdbb-4b97-9a78-3025d0c081c8"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("510c8654-1b21-4479-8c6a-863f90372ac6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("533f8bb8-d3e5-4dcb-b3cc-4df7fe7862a7"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5d213902-7496-4e07-9898-7d82231f8339"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("628363ff-8842-45a0-b9e9-aa0a6a2bc00e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("66371e37-59ba-45d4-9afd-7d543c3fde89"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6a1e53a1-ad9a-4773-897e-d993723eb41b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6bc03f53-8029-4ffb-acf4-d1e446eef7b3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6d8cb999-b260-45b1-8a1e-4e326df57597"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("70811f65-563f-4fe9-b7db-28029f67cce0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("736fc751-2c55-4a91-962c-82c442710ba9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7aaeb000-aa49-4ef8-958f-0b00fba639f9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8cd33cee-7375-4934-8a22-d873097ac929"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8f8775be-ef62-4913-8cef-195cb8aaa03c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("941010b8-7114-4e04-b699-fab0f9d5ba0a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("9dc5b19a-ccf1-43bd-882d-d2bea0214088"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a1545bfe-ef91-4e3c-a7f0-82a144b2dd5e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a4db92e6-e09d-448e-923c-828633ef967f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a9fbf6cb-7229-4c69-8f37-9123694b96e6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b4ab8f67-9c96-4c6f-bca1-f54090591634"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c77d7c7c-d91f-4122-8bd2-a7aae3ee6497"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c9de76d6-cdc2-45b8-81d6-e71e50747d9f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d73a89ce-e002-473c-a76f-1127984bf25f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("da44d172-a50a-491b-a6a9-d69b779d1e7b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ddd24e8c-6b0a-4e36-8850-c9f31750a096"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("decdd898-f86c-412b-93a4-e7e01acacd08"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("dfaab0a4-7665-4abc-9a3f-15dfc0ec9c93"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("dfce02fa-0404-4022-97d2-3a6dc05f693b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e0c88896-da45-43ca-8ff8-7e900af48b65"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e20e9efe-ac0f-4d42-8d5f-e69dce5e5316"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e2d2e104-89a2-4fe9-97c6-7963552e43ac"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e2d6b460-21b1-4173-8735-78af8e43e84d"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e5923b9e-8be8-46d7-b9fd-bbfa1021d118"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e793f69c-174c-4ae0-84ee-cc93c3b95ec1"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e8f9ea64-3f5e-4bd3-a1d8-ad34af287e03"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f74f22f7-039b-45f8-a1ee-3ffc19f734ce"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fef81267-71c8-43ec-bc6f-c28ebf3cf635"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Wishlists");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "UserFavourites");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Memories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Favourites");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Wishlists",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserFavourites",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Memories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Favourites",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFavourites",
                table: "UserFavourites",
                columns: new[] { "UserId", "FavouriteId" });

            migrationBuilder.CreateTable(
                name: "UserMemories",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMemories", x => new { x.UserId, x.MemoryId });
                    table.ForeignKey(
                        name: "FK_UserMemories_Memories_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Memories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMemories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWishlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WishlistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWishlists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWishlists_Wishlists_WishlistId",
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
                    { new Guid("48dcdb4d-656f-46f8-af7c-b470c4040207"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("18b1c9d4-0f46-468b-bae6-efb8ece8493f"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("6113820b-48cf-4ca7-8d81-62cbb46ca8f2"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("0eb64394-8934-4cb1-b8dc-545db1f2f6d5"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("87b802aa-b587-4a52-a85d-b987ea999db8"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("0bc6b7d1-81bd-42d7-91de-a5996daf58d7"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("8e5cc4fe-fe12-43e9-ab01-bcad4ddc4bf1"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("3b93944b-1ec4-4fa8-9450-fa377e0a46c0"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("5dad1dc0-7a40-49cf-bcbe-8fa78286a2e4"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("cfa9c639-eaf9-484c-8649-d8c0b220a5eb"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("faff63e5-1d59-499a-a056-88922841178b"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("e177332f-a6e2-4872-97ac-ebf8eb0e0542"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("f99e3d26-9662-4cb1-97d8-de9389cbe57a"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("5e91347b-4503-422d-b51a-8639d80ee524"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("e1951415-5e6a-4432-bf84-79cd3db36a1e"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("681ea527-7571-401b-8272-33705b36dfea"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("006389d7-3332-488e-9283-7a3837236ca3"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("43b0d967-7b72-43c6-b2b0-f770d00654dc"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("dae63c77-e849-4a2b-95a4-f72c92852997"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("d417fdf9-4124-4c0e-b407-481f10c77360"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("d9b1e4c4-4bc6-4244-9056-39e4a5727bc9"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("2c6c397d-f3ba-41a7-826c-d825bf80d989"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("c0f3780e-c9c7-4190-8cc5-e5a68b78a804"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("6e004184-34cf-40b5-8a88-5e8be5cbe701"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("8b240215-9acd-46aa-93d5-28319c629334"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("6187be63-3274-4294-ae60-97418bad1797"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("b380f009-b30b-4bc6-8336-7ad4ad48ccc9"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("b96283a4-6f74-4908-a72f-b5bd1f6b915e"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("a02d71a7-723d-473c-8a28-1adcd537b6c4"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("56755ca3-abed-4d88-8548-d14f9caa6994"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("63951e6c-c390-405c-a5c6-0862a1a03b21"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("859ca0ec-9596-402d-9772-43630beaf6f9"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("f718505a-8535-4db8-801d-a1515c19671c"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("e4e7aec2-cede-4fb3-9f69-d53f9a419654"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("e2b86f3f-5662-4e18-9219-fa60b4c5198a"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("3ee128df-0316-4449-88f0-3509319bcb69"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("17d46766-0957-49de-b503-faa3aedcdc0b"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("4afaade2-803d-4bac-a20d-fe04bbada748"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("8d93fc42-52e4-4494-852c-2c5020f87203"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("00b217c4-d5fe-4ba4-a6d4-4adbbce89c21"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("8ec2f9ba-bbf2-4872-85ee-01e2b62d9df9"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("554eeef7-39c4-4137-a896-478f6570071d"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("eacce2b9-6ced-4c67-aab6-07682d934225"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("744202f1-a504-42a8-9bfb-0b75e940d325"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("13f78068-d8bc-43c6-8ee2-c2e51dc6e22f"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("0f0f5b09-2885-49a4-b463-5e33ac46078c"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("fc0b59dd-0128-4d19-a4a1-2c8e4118e52e"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("61f46a49-7295-4ca0-a3e3-04429f786a42"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("78ba428a-9243-4cbc-b968-cf0718f93f59"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("a75cb0d0-3486-481b-b01e-f7f3c538ce60"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("c8a726d9-9fbf-47d7-aaec-c2b7f70e5249"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("633bfb34-56b4-47bc-bb4c-16c29d88d75e"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("301daf60-3c4b-4647-ac4f-0e9975fd3a5f"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("2a0fa61d-0438-4534-b891-30905372f7e7"), new Guid("0eb64394-8934-4cb1-b8dc-545db1f2f6d5"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("2dc573a6-59de-4c86-bb13-b3d4eb958060"), new Guid("0bc6b7d1-81bd-42d7-91de-a5996daf58d7"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("fda4464e-be0f-40d0-b5df-2bf709c16651"), new Guid("f99e3d26-9662-4cb1-97d8-de9389cbe57a"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("c9fba597-fe3a-40ad-95f1-2c5730014b59"), new Guid("8e5cc4fe-fe12-43e9-ab01-bcad4ddc4bf1"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("05f89d22-e6cb-416d-85a3-a6cd0d353dba"), new Guid("3b93944b-1ec4-4fa8-9450-fa377e0a46c0"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("41d1990d-5786-498b-8d2b-e130ccef3324"), new Guid("5dad1dc0-7a40-49cf-bcbe-8fa78286a2e4"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("9d0946aa-ad88-45f4-a1f8-95a5daf43eac"), new Guid("cfa9c639-eaf9-484c-8649-d8c0b220a5eb"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("6bd7eec0-134c-46b7-9336-c2e3aea7bfe9"), new Guid("faff63e5-1d59-499a-a056-88922841178b"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("2baa4653-3e9f-4877-92ae-f9fa26bb9774"), new Guid("e177332f-a6e2-4872-97ac-ebf8eb0e0542"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("ac2c7f12-060a-40b3-a2c6-4a4b43eb0072"), new Guid("43b0d967-7b72-43c6-b2b0-f770d00654dc"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("4090830a-c80c-4722-a096-7c942f35681e"), new Guid("e1951415-5e6a-4432-bf84-79cd3db36a1e"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("4b7c2773-4236-4815-afa6-5ac84919489e"), new Guid("681ea527-7571-401b-8272-33705b36dfea"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("82ee6c24-33d5-4ae2-bd3a-ca14f4674c24"), new Guid("006389d7-3332-488e-9283-7a3837236ca3"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("a800ac13-c131-4749-8f16-c7626fe5a17a"), new Guid("d417fdf9-4124-4c0e-b407-481f10c77360"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("5eaa718e-3f74-4559-819e-dba75bc939f7"), new Guid("b380f009-b30b-4bc6-8336-7ad4ad48ccc9"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("a5596a89-7235-42e3-be2e-64b79153bd00"), new Guid("d9b1e4c4-4bc6-4244-9056-39e4a5727bc9"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("76b00b8a-fa58-4562-98a4-67a801fa60fb"), new Guid("2c6c397d-f3ba-41a7-826c-d825bf80d989"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("d2069940-55c0-4f99-9429-43d01926972a"), new Guid("6113820b-48cf-4ca7-8d81-62cbb46ca8f2"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("5cfa3ad3-6693-4e75-b919-d3e5677a5619"), new Guid("c0f3780e-c9c7-4190-8cc5-e5a68b78a804"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("e1a041c9-c4a1-4260-bdbc-17f38ca1b808"), new Guid("5e91347b-4503-422d-b51a-8639d80ee524"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("32eaf261-33ad-45fb-a59e-aa1803bdd403"), new Guid("18b1c9d4-0f46-468b-bae6-efb8ece8493f"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("4bcdfadc-bca2-45dc-bc48-fc237b4125f3"), new Guid("8d93fc42-52e4-4494-852c-2c5020f87203"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("80751467-160d-4732-a29b-6ade1021a430"), new Guid("301daf60-3c4b-4647-ac4f-0e9975fd3a5f"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("2f278159-2801-4afe-83ae-432f354296da"), new Guid("6e004184-34cf-40b5-8a88-5e8be5cbe701"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("8cfb5a67-52f3-4522-a44e-48fd558ec8ed"), new Guid("48dcdb4d-656f-46f8-af7c-b470c4040207"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("37f728d3-1ec7-487c-8d64-0ec5c47a9ea0"), new Guid("56755ca3-abed-4d88-8548-d14f9caa6994"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("0f75ea5e-795e-4b22-b92f-3adceaa1c320"), new Guid("8ec2f9ba-bbf2-4872-85ee-01e2b62d9df9"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("0f891b61-13ec-44ba-be00-70a57b20024c"), new Guid("859ca0ec-9596-402d-9772-43630beaf6f9"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("aa198753-7190-4206-974b-ccf2f62c0edf"), new Guid("f718505a-8535-4db8-801d-a1515c19671c"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("08666394-43d0-4279-9eef-874035430b04"), new Guid("e2b86f3f-5662-4e18-9219-fa60b4c5198a"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("df4e0761-a582-4a60-a73c-dda956b15c13"), new Guid("3ee128df-0316-4449-88f0-3509319bcb69"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("acdf0633-1131-41cf-817c-fffe99a82c49"), new Guid("17d46766-0957-49de-b503-faa3aedcdc0b"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("26cbef6c-0b21-4cd1-85dc-61d66692963c"), new Guid("b96283a4-6f74-4908-a72f-b5bd1f6b915e"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("c50426ce-9c04-462a-bde3-c9b8b5281349"), new Guid("4afaade2-803d-4bac-a20d-fe04bbada748"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("e52a8f01-39e8-44ce-94ef-ca623767c42c"), new Guid("eacce2b9-6ced-4c67-aab6-07682d934225"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("755e52a9-73ec-4e84-bd58-e19a9173fb6c"), new Guid("554eeef7-39c4-4137-a896-478f6570071d"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("3f234a3a-9e04-45d8-80b1-ada1835fd765"), new Guid("c8a726d9-9fbf-47d7-aaec-c2b7f70e5249"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("fbac21b1-ab26-4c33-b202-5c3e09fc58de"), new Guid("a75cb0d0-3486-481b-b01e-f7f3c538ce60"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("921bc83a-b70b-4a65-beaa-96c9978924f9"), new Guid("78ba428a-9243-4cbc-b968-cf0718f93f59"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("008dd53b-7911-497c-9569-48e852e4c677"), new Guid("61f46a49-7295-4ca0-a3e3-04429f786a42"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("35827e3f-fdd9-4049-a75e-94a57d32744e"), new Guid("13f78068-d8bc-43c6-8ee2-c2e51dc6e22f"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("7bc500b8-21b1-4dd7-b9a0-0f7a596c062d"), new Guid("fc0b59dd-0128-4d19-a4a1-2c8e4118e52e"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("199ce7c9-1837-4135-91e5-185a8b0c2b47"), new Guid("744202f1-a504-42a8-9bfb-0b75e940d325"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("b3f4abc5-dea4-419f-a7d9-fafe955428e6"), new Guid("00b217c4-d5fe-4ba4-a6d4-4adbbce89c21"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5311214-564f-4824-ba65-b57042349e49"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMzE3QwoMa1VPVu7U1FHSTf1+p9K59pvoS0pVwmzucbK0KrhPGJVhuSKXI053AGekA==");

            migrationBuilder.CreateIndex(
                name: "IX_UserMemories_MemoryId",
                table: "UserMemories",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWishlists_UserId",
                table: "UserWishlists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWishlists_WishlistId",
                table: "UserWishlists",
                column: "WishlistId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavourites_Users_UserId",
                table: "UserFavourites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}