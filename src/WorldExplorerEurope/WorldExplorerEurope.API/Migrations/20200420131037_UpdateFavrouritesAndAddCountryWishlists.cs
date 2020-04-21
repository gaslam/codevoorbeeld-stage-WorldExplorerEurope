using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldExplorerEurope.API.Migrations
{
    public partial class UpdateFavrouritesAndAddCountryWishlists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavourites_Countries_CountryId",
                table: "UserFavourites");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavourites_Favourites_FavouriteId",
                table: "UserFavourites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryWishlists",
                table: "CountryWishlists");

            migrationBuilder.DropIndex(
                name: "IX_CountryWishlists_CountryId",
                table: "CountryWishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserFavourites",
                table: "UserFavourites");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00016d55-7bbe-4d2a-8c09-5f85e421c476"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0218fb00-203f-4f0e-a9c1-0b70a0bc469f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02a5aed2-135d-41c7-bc64-da9b24871850"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06798762-636b-4bd9-abb3-2b1f9d68fbb3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("108a84b9-cbb7-44c2-9f14-74b118f75854"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("193e1ed6-bce1-492d-a6eb-e4069760012d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1cb882f5-50a6-4837-b104-92ff133695dd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2190eb1a-ed12-4dfe-8b9c-54db07dd6532"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2286d285-c874-4a84-84a9-0d67bf583b84"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a253033-b123-4f7c-9bc1-5abff034c8f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("45cfe938-5690-4ed0-bee4-0db49b010985"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("495c5b51-4515-420b-b9b1-e0340d6c7bb8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a874e36-fab4-4fb5-a74a-dba0fb13d589"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("57fa841a-fc01-4440-8e2d-116de92538f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6869d6d4-29a0-4306-a349-e20a4ad7d2b7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f6b375d-9f45-4ad4-aa58-33d65c749c21"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7233d305-0fcb-4395-9da6-cf3288302308"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("78322940-9409-41a4-9bac-21d1be36482f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7e9234ad-c86d-40ee-b1fc-13537408f527"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("825e6478-04ff-4185-b639-e3998108cf60"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("85955373-cb95-45f5-baa4-cc3187157645"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("88125506-773a-4998-88d8-bcd52ca658e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92b096b0-bdb9-4060-a7df-40e7c2082c40"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("93bbba4d-854e-450b-be0b-9338a23a4145"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("952a5bdd-ca6d-4a18-b361-ecfa893f01d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("995849f4-c234-4fda-bbca-b384a5b397d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a9305f0-1172-4ab4-a5a4-8abe31c08202"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a2861a66-c1fd-4253-bd7d-e989c78923e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a7f92b47-4ec0-4f21-acfe-3632421d6e34"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0312a78-392c-46e9-8cdb-d254165123a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b0eeb18c-371e-46ba-92d0-c515c5bd739a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b6d2210d-719c-4d34-98ed-83d2fa86b639"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ba22eedb-0038-4fb5-bf29-b4179a4574d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf515e4d-3094-4e8c-9888-b1e84ab4f948"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3608a96-7a98-4e67-a1b5-a8629e92752d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6b84a59-ec04-4fad-8d72-c8a8a77ecbac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7bbb690-5992-406b-9519-a16393efbd51"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca4aac75-3b20-4724-b922-5cc58eeaae47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb45f420-e051-430c-86e9-9feda99dcd08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cc2c020b-6b1f-4787-820b-0af3c2e1df15"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cd95e0d1-73e9-4893-ab7f-466c06cd92c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ceed2cd9-7e4e-4bdb-a995-b31b379e7139"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf1defd6-cebf-4d0a-a155-ec44855d4054"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d05cfd98-3d1b-4705-870d-5a2278200ba2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d6ad166e-29d0-4ead-9e3f-eadd27b7c42b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d8c942a0-feab-4619-8379-86dba9bc41ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de0867f7-968c-4614-b11f-54ebe298030c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("de72baa4-5d01-40a8-8662-a1f4bf75e355"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e24d34a7-cb74-49bc-a2c2-84f164d162ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e59f566b-a7b3-493d-a7e1-eb14fe7f15b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ed52629d-7e23-4395-832a-a6986461bbab"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4b2238f-92d2-4bcb-97e1-0f4ab914fa14"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ff0e9bad-8828-45f8-8e40-1aec6f414fa3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("01b51d64-7f17-4ee4-9b28-a321f05c3633"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("03b10037-82c6-4ab2-9a98-e12031261ebb"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("0516c480-74d1-401a-91dd-1cf8b4dd9ea9"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("12cc2b61-636f-4ffe-92f3-a8486d0165a4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("17940bbf-a09e-434f-9a76-ce4e773e6830"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("18ccbd7d-49a8-43f3-b687-f3d5b14de0e0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1d0bbf92-0638-4c9a-8175-204c2bac5cfa"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1df5afa9-131c-48c6-9857-588455e3dff4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("318443cb-0989-4f9d-b45d-e388995d4313"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("349a1d32-2846-426b-8e7e-800955d30d47"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("39c14ed8-257f-4360-b4d2-81d5dc504594"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4d82aa8c-66f1-4724-a1ed-5ed1fb4fe4fc"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4dd911f0-5c97-451f-b6e6-4117cb4742bb"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4f748c60-33c3-44e6-b167-f4f42243fd65"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("518825c0-17ed-419a-acc3-5924152deaa4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5cb95a95-23b1-48fc-a5c0-61ede947bdde"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5e3e3200-7493-445c-90fa-a773e40353e6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8a944c8a-b1fe-4301-8b21-e93c16a29ab5"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8b1a508c-a39e-4f77-b3ca-7ff54b53e6bd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8f426bee-d749-4f8a-8cbd-62b1466f01dd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("946bcd1b-11e1-4829-8268-dc92e5259913"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("9aef17fa-3ebe-458f-a815-2bdea108e5d4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("9b3f8449-0a9d-4de1-b216-857d4106e48d"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("a3f820f6-f001-4b37-aaa3-565eaf38a16e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ae5625de-fc78-4dbe-a156-4fb0b84fe7d0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b1f0ab9f-acaa-4e50-a461-c522e2136b1c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b2e1f5d2-99c7-4187-952a-1f94c70dc13c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b4cc1942-372c-4a36-b9ca-d7cda89a9b48"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c1c30e7a-b09d-4c5f-9a5e-b2c03c42bb64"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c2a3ac1b-57b0-48a9-a224-fd0481e092c2"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c46985a8-d7a6-4051-92a7-c4bf6522620a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("c8825dac-09d8-45a1-aca3-9dd1ff0683b8"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("cbd309e8-e0f0-4363-bad2-0c9855dcf3a5"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("cc54683c-52b8-4ca8-8d82-46727208d425"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d35db354-ced0-41bd-b1c5-02ef7ba5fc51"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d910bd9d-bd9f-4519-b481-3e74966a3102"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("dbaad6c0-307f-4ab3-bcd9-843bf75f6d45"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e0da32ab-a951-4b19-b22d-f240b1ad213b"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e34b3593-c3e0-4afe-9f08-870497fadd41"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("e915cd7b-d8a0-4335-a618-4b083b039f94"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("eb5dfd22-3d3f-4315-9e66-2ed56e12feeb"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ecd2d135-53af-46d1-b5be-87c09a28059e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f5e6e153-6169-4c21-b9f8-1a142b7a29ec"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fd7cb5ea-f84d-4aab-9ecb-85eda19e9a45"));

            migrationBuilder.RenameTable(
                name: "UserFavourites",
                newName: "CountryFavourites");

            migrationBuilder.RenameIndex(
                name: "IX_UserFavourites_FavouriteId",
                table: "CountryFavourites",
                newName: "IX_CountryFavourites_FavouriteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryWishlists",
                table: "CountryWishlists",
                columns: new[] { "CountryId", "WishlistId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryFavourites",
                table: "CountryFavourites",
                columns: new[] { "CountryId", "FavouriteId" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Currency", "Description", "Flag", "IsEUMember", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("d20a8d1d-3e45-421a-a097-eec2c5bf177a"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("183cdb1f-e511-494a-85c7-41f8ec5f3a5d"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("71b948f5-68c8-41f5-9fd1-e3eb78617306"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("881d5b87-c30f-4e19-85a3-4f196fad74e8"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("3ae0bbe5-0c40-4011-b02d-4a56d306c1f6"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("73a22988-16a9-440f-9145-82fa2250da10"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("706b46f6-4ce6-4e92-a8e5-e4c773e3316b"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("e670560f-25ee-4aaf-9758-f89bf6a6b9ed"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("f77864bd-5141-4ca4-bc0d-959a878c09cb"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("533ec7c7-62ba-4f22-b760-46ca59226a90"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("c07144b1-f2d9-4c57-ae06-61d9b5ff3b9f"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("192f1e94-51b6-4ca0-ba5e-428189e84b0e"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("d716d580-ba5e-464e-bca1-e099a2442cce"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("3abec739-2ed7-43cf-8f67-abc8f9218371"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("518b5a7f-875d-4be9-8e44-dc620fccae8e"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("1ff95b3e-d58f-4b53-b87d-2e64a95e281b"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("3f05c5cd-b29d-42a6-bc80-7dccb4d7e076"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("440ad017-6f1d-4836-9838-6efb6636417f"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("02680042-a2e8-407b-9bb2-1a4176440a93"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("2114115e-871a-4ce3-a06d-6d6d159c3e41"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("8b8680fc-f7e5-483a-b19a-112b531ac051"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("645b106e-df6c-4b01-a907-5ef4f7cc8c68"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("58050df8-5a8f-45a6-ad45-4ad83a5942ea"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("b11caf2a-3df4-4a87-a46c-d4d06190bd62"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("87e212f3-77f8-41dc-a456-8e8468cdbc3c"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("c8ee97d0-7539-4927-8e09-66b16c17e8c7"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("f024b036-99c0-4b1e-8473-65deca3dee80"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("2a779733-1c5b-4bc0-9ef7-83a8e29e1d7a"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("74e04ff7-f09e-45da-9166-725719510120"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("e2d28416-b4fc-4b30-96a5-5717218fad81"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("15e01042-beae-41d2-84e3-5dd3fdaba4ae"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("00561082-9af4-4371-a9cf-0813e2b24891"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("33491fa2-21dc-4b18-9054-5ae348a908ec"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("0b0d81b7-54e4-4569-80fb-137974b4498e"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("8f1872a7-8bee-42d7-a19e-70c702c9d406"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("2af03df9-8fbe-4f4c-8c68-5e1f41fe1048"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("feb46c70-2655-42d1-bfde-22628d303470"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("f56e337e-aeab-4164-9685-172e93e4fa73"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("17834683-b36a-48ff-8b91-f8d3a4a59994"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("d910ae08-05ad-4e14-af8e-e0e0a259e309"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("f8b1bc4d-1263-45ea-a629-c91a317fe0d4"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("c63ba8ac-da1b-4729-b6e9-f57a43bc14c2"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("7bcac10d-49e3-4392-b08a-bcde6f9b7b09"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("a3a8cf90-2e0e-4f17-a77c-7573c853ae98"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("4817bea3-41a8-4c5b-a321-a3818a6cc381"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("37b367b1-7714-4328-b124-daf0f1888023"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("b58ff191-2e5a-4106-8dfd-d22e6113d838"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("51a5b610-b58b-4b6b-a3f4-1831f80e4e1f"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("7fbf76c2-bdbf-4061-8ce1-8cd2889e14ca"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("8d1cf96d-2ed0-4f2e-8a71-c4b71e7d51f2"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("58fc4f00-749f-4d2c-a01e-6147185ebff4"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("57b116ba-bc30-4830-9da6-e0f1487e241c"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("67c2a9f7-2f46-4caa-8e59-6b1e8a398938"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("fe85774a-f0b9-4440-b877-db5f50b55427"), new Guid("881d5b87-c30f-4e19-85a3-4f196fad74e8"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("43607949-a81f-4418-8f98-ada362477a10"), new Guid("73a22988-16a9-440f-9145-82fa2250da10"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("7ba1b9e5-3730-4e72-a883-70bcd00b51c8"), new Guid("d716d580-ba5e-464e-bca1-e099a2442cce"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("f0298dad-f387-4ee0-8f86-75baf5520c49"), new Guid("706b46f6-4ce6-4e92-a8e5-e4c773e3316b"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("764df653-667d-4b7e-b7a0-93e4bbb84710"), new Guid("e670560f-25ee-4aaf-9758-f89bf6a6b9ed"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("6ff3bfb4-12a6-4851-8699-13bbde0cadf0"), new Guid("f77864bd-5141-4ca4-bc0d-959a878c09cb"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("4b60d0f6-dacb-4236-9092-2ee2d39fb8a3"), new Guid("533ec7c7-62ba-4f22-b760-46ca59226a90"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("9ad77bdd-9b3d-43db-8641-865172c3b4ef"), new Guid("c07144b1-f2d9-4c57-ae06-61d9b5ff3b9f"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("fd4db648-1e2f-4fa8-826e-b6a2bb66bbbe"), new Guid("192f1e94-51b6-4ca0-ba5e-428189e84b0e"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("2baf035f-67d1-4416-bc79-e6d94b0dd7e0"), new Guid("440ad017-6f1d-4836-9838-6efb6636417f"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("3b0290ec-a607-4a9e-85c2-07a304962741"), new Guid("518b5a7f-875d-4be9-8e44-dc620fccae8e"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("6a0951b1-01a8-4fe1-9476-4e41eac0afb6"), new Guid("1ff95b3e-d58f-4b53-b87d-2e64a95e281b"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("8dff155d-f0d7-4045-8b1e-bbc33fb8e913"), new Guid("3f05c5cd-b29d-42a6-bc80-7dccb4d7e076"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("545a6fb3-7f43-4748-9444-bacdf535b7a6"), new Guid("2114115e-871a-4ce3-a06d-6d6d159c3e41"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("8eb3ef08-2123-48ee-b26b-7f6b445dcb8a"), new Guid("f024b036-99c0-4b1e-8473-65deca3dee80"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("d943478b-aaca-4852-ac7d-3dc6ee0d882a"), new Guid("8b8680fc-f7e5-483a-b19a-112b531ac051"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("21e6aff1-c738-4777-8621-978ddb336b0d"), new Guid("645b106e-df6c-4b01-a907-5ef4f7cc8c68"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("7a672d14-331e-4438-943e-cf14330cd7b7"), new Guid("71b948f5-68c8-41f5-9fd1-e3eb78617306"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("b7a5e5e6-371f-4de6-a321-0b8faf84d1bf"), new Guid("58050df8-5a8f-45a6-ad45-4ad83a5942ea"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("6d2a1eed-2e60-4e9f-97ef-2a408bbf498c"), new Guid("3abec739-2ed7-43cf-8f67-abc8f9218371"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("f68457cf-933a-4570-b246-0b5681c01d6f"), new Guid("183cdb1f-e511-494a-85c7-41f8ec5f3a5d"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("1108e109-7331-4dcd-b53c-1ce8f7b9e6a6"), new Guid("17834683-b36a-48ff-8b91-f8d3a4a59994"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("f0ea32b8-cfcb-48eb-b729-fb1fe8749dbf"), new Guid("67c2a9f7-2f46-4caa-8e59-6b1e8a398938"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("187f69e2-b2c2-4374-93a8-f60cea145a45"), new Guid("b11caf2a-3df4-4a87-a46c-d4d06190bd62"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("b3145322-7395-49c0-8477-a29760690d3f"), new Guid("d20a8d1d-3e45-421a-a097-eec2c5bf177a"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("5711149c-7b47-4137-80b1-f03e930d000e"), new Guid("e2d28416-b4fc-4b30-96a5-5717218fad81"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("73b27a24-87ee-4701-ac76-e90aebab6734"), new Guid("f8b1bc4d-1263-45ea-a629-c91a317fe0d4"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("2b7007a2-db15-4570-9b96-7a3acac44f86"), new Guid("00561082-9af4-4371-a9cf-0813e2b24891"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("7d2e9261-c681-4c59-a9ff-732a4cdd9f17"), new Guid("33491fa2-21dc-4b18-9054-5ae348a908ec"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("86c2fd7b-72f6-4bb3-bcbc-a4a864cbea43"), new Guid("8f1872a7-8bee-42d7-a19e-70c702c9d406"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("6f3c2e19-472c-4dfc-83bb-434e3176a3c3"), new Guid("2af03df9-8fbe-4f4c-8c68-5e1f41fe1048"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("075cf35d-8437-475f-8029-d39876ce2002"), new Guid("feb46c70-2655-42d1-bfde-22628d303470"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("6e7eb506-4cdc-4b9e-ba45-881548151ffd"), new Guid("2a779733-1c5b-4bc0-9ef7-83a8e29e1d7a"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("09bf86d8-cde8-4542-82bc-bbfbc28e1acf"), new Guid("f56e337e-aeab-4164-9685-172e93e4fa73"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("af252ff4-7300-4302-9bf0-c67c39a3ab11"), new Guid("7bcac10d-49e3-4392-b08a-bcde6f9b7b09"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("0b7b297b-9884-4e5b-adf0-5a4fa53ada27"), new Guid("c63ba8ac-da1b-4729-b6e9-f57a43bc14c2"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("5d4d2434-5695-4aba-bd28-1dea19a0967f"), new Guid("58fc4f00-749f-4d2c-a01e-6147185ebff4"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("bf735ac4-c8b5-4572-8357-4689719a9344"), new Guid("8d1cf96d-2ed0-4f2e-8a71-c4b71e7d51f2"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("fcf16917-e517-4e85-8dc8-0db9641ba82f"), new Guid("7fbf76c2-bdbf-4061-8ce1-8cd2889e14ca"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("da77ce64-5a51-4f30-8a35-4ba2070a47b4"), new Guid("51a5b610-b58b-4b6b-a3f4-1831f80e4e1f"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("ec3f72ab-29b1-4cc1-857e-73cc21b0b826"), new Guid("4817bea3-41a8-4c5b-a321-a3818a6cc381"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("b0c324af-6ffb-41df-b4c3-0e4187d56004"), new Guid("b58ff191-2e5a-4106-8dfd-d22e6113d838"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("dc2658a6-70c3-479f-a87d-844159e1d8fc"), new Guid("a3a8cf90-2e0e-4f17-a77c-7573c853ae98"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("8e4a4f14-83ce-4166-9232-f9f322082957"), new Guid("d910ae08-05ad-4e14-af8e-e0e0a259e309"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5311214-564f-4824-ba65-b57042349e49"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMvGRPT8TNEC2oGWdmO4CBPPc5bEMbpi0FYi7OvV4HVsa0FUH5tljBdIIYKASMENXQ==");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryFavourites_Countries_CountryId",
                table: "CountryFavourites",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryFavourites_Favourites_FavouriteId",
                table: "CountryFavourites",
                column: "FavouriteId",
                principalTable: "Favourites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryFavourites_Countries_CountryId",
                table: "CountryFavourites");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryFavourites_Favourites_FavouriteId",
                table: "CountryFavourites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryWishlists",
                table: "CountryWishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryFavourites",
                table: "CountryFavourites");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00561082-9af4-4371-a9cf-0813e2b24891"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02680042-a2e8-407b-9bb2-1a4176440a93"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b0d81b7-54e4-4569-80fb-137974b4498e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15e01042-beae-41d2-84e3-5dd3fdaba4ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17834683-b36a-48ff-8b91-f8d3a4a59994"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("183cdb1f-e511-494a-85c7-41f8ec5f3a5d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("192f1e94-51b6-4ca0-ba5e-428189e84b0e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1ff95b3e-d58f-4b53-b87d-2e64a95e281b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2114115e-871a-4ce3-a06d-6d6d159c3e41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2a779733-1c5b-4bc0-9ef7-83a8e29e1d7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2af03df9-8fbe-4f4c-8c68-5e1f41fe1048"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33491fa2-21dc-4b18-9054-5ae348a908ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("37b367b1-7714-4328-b124-daf0f1888023"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3abec739-2ed7-43cf-8f67-abc8f9218371"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ae0bbe5-0c40-4011-b02d-4a56d306c1f6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3f05c5cd-b29d-42a6-bc80-7dccb4d7e076"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("440ad017-6f1d-4836-9838-6efb6636417f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4817bea3-41a8-4c5b-a321-a3818a6cc381"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("518b5a7f-875d-4be9-8e44-dc620fccae8e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("51a5b610-b58b-4b6b-a3f4-1831f80e4e1f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("533ec7c7-62ba-4f22-b760-46ca59226a90"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("57b116ba-bc30-4830-9da6-e0f1487e241c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58050df8-5a8f-45a6-ad45-4ad83a5942ea"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58fc4f00-749f-4d2c-a01e-6147185ebff4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("645b106e-df6c-4b01-a907-5ef4f7cc8c68"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67c2a9f7-2f46-4caa-8e59-6b1e8a398938"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("706b46f6-4ce6-4e92-a8e5-e4c773e3316b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71b948f5-68c8-41f5-9fd1-e3eb78617306"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73a22988-16a9-440f-9145-82fa2250da10"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("74e04ff7-f09e-45da-9166-725719510120"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7bcac10d-49e3-4392-b08a-bcde6f9b7b09"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7fbf76c2-bdbf-4061-8ce1-8cd2889e14ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("87e212f3-77f8-41dc-a456-8e8468cdbc3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("881d5b87-c30f-4e19-85a3-4f196fad74e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b8680fc-f7e5-483a-b19a-112b531ac051"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8d1cf96d-2ed0-4f2e-8a71-c4b71e7d51f2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f1872a7-8bee-42d7-a19e-70c702c9d406"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3a8cf90-2e0e-4f17-a77c-7573c853ae98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b11caf2a-3df4-4a87-a46c-d4d06190bd62"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b58ff191-2e5a-4106-8dfd-d22e6113d838"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c07144b1-f2d9-4c57-ae06-61d9b5ff3b9f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c63ba8ac-da1b-4729-b6e9-f57a43bc14c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8ee97d0-7539-4927-8e09-66b16c17e8c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d20a8d1d-3e45-421a-a097-eec2c5bf177a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d716d580-ba5e-464e-bca1-e099a2442cce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d910ae08-05ad-4e14-af8e-e0e0a259e309"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e2d28416-b4fc-4b30-96a5-5717218fad81"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e670560f-25ee-4aaf-9758-f89bf6a6b9ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f024b036-99c0-4b1e-8473-65deca3dee80"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f56e337e-aeab-4164-9685-172e93e4fa73"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f77864bd-5141-4ca4-bc0d-959a878c09cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8b1bc4d-1263-45ea-a629-c91a317fe0d4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("feb46c70-2655-42d1-bfde-22628d303470"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("075cf35d-8437-475f-8029-d39876ce2002"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("09bf86d8-cde8-4542-82bc-bbfbc28e1acf"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("0b7b297b-9884-4e5b-adf0-5a4fa53ada27"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("1108e109-7331-4dcd-b53c-1ce8f7b9e6a6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("187f69e2-b2c2-4374-93a8-f60cea145a45"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("21e6aff1-c738-4777-8621-978ddb336b0d"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2b7007a2-db15-4570-9b96-7a3acac44f86"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("2baf035f-67d1-4416-bc79-e6d94b0dd7e0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("3b0290ec-a607-4a9e-85c2-07a304962741"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("43607949-a81f-4418-8f98-ada362477a10"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("4b60d0f6-dacb-4236-9092-2ee2d39fb8a3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("545a6fb3-7f43-4748-9444-bacdf535b7a6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5711149c-7b47-4137-80b1-f03e930d000e"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("5d4d2434-5695-4aba-bd28-1dea19a0967f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6a0951b1-01a8-4fe1-9476-4e41eac0afb6"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6d2a1eed-2e60-4e9f-97ef-2a408bbf498c"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6e7eb506-4cdc-4b9e-ba45-881548151ffd"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6f3c2e19-472c-4dfc-83bb-434e3176a3c3"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("6ff3bfb4-12a6-4851-8699-13bbde0cadf0"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("73b27a24-87ee-4701-ac76-e90aebab6734"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("764df653-667d-4b7e-b7a0-93e4bbb84710"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7a672d14-331e-4438-943e-cf14330cd7b7"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7ba1b9e5-3730-4e72-a883-70bcd00b51c8"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("7d2e9261-c681-4c59-a9ff-732a4cdd9f17"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("86c2fd7b-72f6-4bb3-bcbc-a4a864cbea43"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8dff155d-f0d7-4045-8b1e-bbc33fb8e913"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8e4a4f14-83ce-4166-9232-f9f322082957"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("8eb3ef08-2123-48ee-b26b-7f6b445dcb8a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("9ad77bdd-9b3d-43db-8641-865172c3b4ef"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("af252ff4-7300-4302-9bf0-c67c39a3ab11"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b0c324af-6ffb-41df-b4c3-0e4187d56004"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b3145322-7395-49c0-8477-a29760690d3f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("b7a5e5e6-371f-4de6-a321-0b8faf84d1bf"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("bf735ac4-c8b5-4572-8357-4689719a9344"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("d943478b-aaca-4852-ac7d-3dc6ee0d882a"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("da77ce64-5a51-4f30-8a35-4ba2070a47b4"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("dc2658a6-70c3-479f-a87d-844159e1d8fc"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("ec3f72ab-29b1-4cc1-857e-73cc21b0b826"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f0298dad-f387-4ee0-8f86-75baf5520c49"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f0ea32b8-cfcb-48eb-b729-fb1fe8749dbf"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("f68457cf-933a-4570-b246-0b5681c01d6f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fcf16917-e517-4e85-8dc8-0db9641ba82f"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fd4db648-1e2f-4fa8-826e-b6a2bb66bbbe"));

            migrationBuilder.DeleteData(
                table: "CountrySpotifyPlaylist",
                keyColumn: "Id",
                keyValue: new Guid("fe85774a-f0b9-4440-b877-db5f50b55427"));

            migrationBuilder.RenameTable(
                name: "CountryFavourites",
                newName: "UserFavourites");

            migrationBuilder.RenameIndex(
                name: "IX_CountryFavourites_FavouriteId",
                table: "UserFavourites",
                newName: "IX_UserFavourites_FavouriteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryWishlists",
                table: "CountryWishlists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserFavourites",
                table: "UserFavourites",
                columns: new[] { "CountryId", "FavouriteId" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Currency", "Description", "Flag", "IsEUMember", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("c6b84a59-ec04-4fad-8d72-c8a8a77ecbac"), "Mariehamn", "Euro", "The Åland Islands or Åland is an archipelago province at the entrance to the Gulf of Bothnia in the Baltic Sea belonging to Finland. It is autonomous, demilitarised and is the only monolingually Swedish-speaking region in Finland. It is the smallest region of Finland, constituting 0.51% of its land area and 0.54% of its population.", "https://restcountries.eu/data/ala.svg", true, "Åland Islands", 28875L },
                    { new Guid("7233d305-0fcb-4395-9da6-cf3288302308"), "Vilnius", "Euro", "Lithuania, officially the Republic of Lithuania, is a country in the Baltic region of Europe. Lithuania is considered to be one of the Baltic states. The country is situated along the southeastern shore of the Baltic Sea, to the east of Sweden and Denmark. It is bordered by Latvia to the north, Belarus to the east and south, Poland to the south, and Kaliningrad Oblast to the southwest. Lithuania has an estimated population of 2.8 million people as of 2019, and its capital and largest city is Vilnius. Other major cities are Kaunas and Klaipėda. Lithuanians are Baltic people. The official language, Lithuanian, is one of only two living languages in the Baltic branch of the Indo-European language family, the other being Latvian.", "https://restcountries.eu/data/ltu.svg", true, "Lithuania", 2872294L },
                    { new Guid("c3608a96-7a98-4e67-a1b5-a8629e92752d"), "Luxembourg", "Euro", "Luxembourg, officially the Grand Duchy of Luxembourg, is a landlocked country in western Europe. It is bordered by Belgium to the west and north, Germany to the east, and France to the south. Its capital, Luxembourg City, is one of the four official capitals of the European Union and the seat of the European Court of Justice, the highest judicial authority in the EU. Its culture, people, and languages are highly intertwined with its neighbours, making it essentially a mixture of French and German cultures, as evident by the nation's three official languages: French, German, and the national language of Luxembourgish. The repeated invasions by Germany, especially in World War II, resulted in the country's strong will for mediation between France and Germany and, among other things, led to the foundation of the European Union.", "https://restcountries.eu/data/lux.svg", true, "Luxembourg", 576200L },
                    { new Guid("78322940-9409-41a4-9bac-21d1be36482f"), "Skopje", "Macedonian denar", @"Macedonia most commonly refers to:North Macedonia, a country in southeastern Europe, formerly known as the Republic of Macedonia
                Macedonia, a kingdom in Greek antiquity
                Macedonia (Greece), a traditional geographic region spanning three administrative divisions of northern Greece
                Macedonia (region), a geographic and historical region that today includes parts of six Balkan countries ", "https://restcountries.eu/data/mkd.svg", true, "Macedonia ", 2058539L },
                    { new Guid("b0eeb18c-371e-46ba-92d0-c515c5bd739a"), "Valletta", "Euro", "Malta, officially known as the Republic of Malta, is a Southern European island country consisting of an archipelago in the Mediterranean Sea. It lies 80 km (50 mi) south of Italy, 284 km (176 mi) east of Tunisia, and 333 km (207 mi) north of Libya. With a population of about 475,000 over an area of 316 km2 (122 sq mi), Malta is the world's tenth smallest in area and fifth most densely populated sovereign country. Its capital is Valletta, which is the smallest national capital in the European Union by area at 0.8 km2 (0.31 sq mi). The official and national language is Maltese, which is descended from Sicilian Arabic that developed during the Emirate of Sicily, while English serves as the second official language.", "https://restcountries.eu/data/mlt.svg", true, "Malta", 425384L },
                    { new Guid("ceed2cd9-7e4e-4bdb-a995-b31b379e7139"), "Chișinău", "Moldovan leu", "Moldova, officially the Republic of Moldova, is a landlocked country in Eastern Europe, bordered by Romania to the west and Ukraine to the north, east, and south. The capital city is Chișinău.", "https://restcountries.eu/data/mda.svg", true, "Moldova ", 3553100L },
                    { new Guid("825e6478-04ff-4185-b639-e3998108cf60"), "Monaco", "Euro", "Monaco, officially the Principality of Monaco, is a sovereign city-state, country, and microstate on the French Riviera in Western Europe. France borders the country on three sides while the other side borders the Mediterranean Sea. Monaco is about 15 km (9.3 mi) from the state border with Italy.", "https://restcountries.eu/data/mco.svg", true, "Monaco", 38400L },
                    { new Guid("92b096b0-bdb9-4060-a7df-40e7c2082c40"), "Podgorica", "Euro", "Montenegro is a country of South and Southeast Europe on the coast of the Balkans. It borders Bosnia-Herzegovina to the northwest, Serbia to the northeast, Kosovo to the east, Albania to the southeast, the Adriatic Sea to the southwest, and Croatia to the west. Montenegro has an area of 13,812 square kilometres and a population of 620,079. Its capital, Podgorica, is one of the twenty-three municipalities in the country. Cetinje is designated as the Old Royal Capital.", "https://restcountries.eu/data/mne.svg", true, "Montenegro", 621810L },
                    { new Guid("9a9305f0-1172-4ab4-a5a4-8abe31c08202"), "Amsterdam", "Euro", "The Netherlands, informally Holland, is a country in Northwestern Europe with some overseas territories in the Caribbean. In Europe, it consists of 12 provinces that border Germany to the east, Belgium to the south, and the North Sea to the northwest, with maritime borders in the North Sea with those countries and the United Kingdom. Together with the Caribbean Netherlands —Bonaire, Sint Eustatius and Saba—it forms a constituent country of the Kingdom of the Netherlands. The official language is Dutch and a secondary official language in the province of Friesland is West Frisian. In the north and east of the country, Low Saxon is also spoken, and in the southeast, Limburgish. In the Caribbean Netherlands English and Papiamento are recognised languages.", "https://restcountries.eu/data/nld.svg", true, "Netherlands", 17019800L },
                    { new Guid("6869d6d4-29a0-4306-a349-e20a4ad7d2b7"), "Oslo", "Norwegian krone", "Norway, officially the Kingdom of Norway, is a Nordic country in Northwestern Europe whose territory comprises the western and northernmost portion of the Scandinavian Peninsula; the remote island of Jan Mayen and the archipelago of Svalbard are also part of the Kingdom of Norway. The sub-Antarctic Bouvet Island is a dependent territory and thus not considered part of the kingdom. Norway also lays claim to the Antarctic territories of Queen Maud Land and Peter I Island.", "https://restcountries.eu/data/nor.svg", true, "Norway", 5223256L },
                    { new Guid("193e1ed6-bce1-492d-a6eb-e4069760012d"), "Warsaw", "Polish złoty", "Poland, officially the Republic of Poland, is a country located in Central Europe. It is divided into 16 administrative subdivisions, covering an area of 312,696 square kilometres (120,733 sq mi), and has a largely temperate seasonal climate. With a population of nearly 38.5 million people, Poland is the fifth most populous member state of the European Union. Poland's capital and largest metropolis is Warsaw. Other major cities include Kraków, Łódź, Wrocław, Poznań, Gdańsk, and Szczecin.", "https://restcountries.eu/data/pol.svg", true, "Poland", 38437239L },
                    { new Guid("0218fb00-203f-4f0e-a9c1-0b70a0bc469f"), "Lisbon", "Euro", "Portugal, officially the Portuguese Republic, is a country located mostly on the Iberian Peninsula, in southwestern Europe. It is the westernmost sovereign state of mainland Europe, being bordered to the west and south by the Atlantic Ocean and to the north and east by Spain. Its territory also includes the Atlantic archipelagos of the Azores and Madeira, both autonomous regions with their own regional governments.", "https://restcountries.eu/data/prt.svg", true, "Portugal", 10374822L },
                    { new Guid("02a5aed2-135d-41c7-bc64-da9b24871850"), "Pristina", "Euro", "Kosovo, officially the Republic of Kosovo, is a partially-recognized state in Southeast Europe, subject to a territorial dispute with the Republic of Serbia.", "https://restcountries.eu/data/kos.svg", true, "Republic of Kosovo", 1733842L },
                    { new Guid("b0312a78-392c-46e9-8cdb-d254165123a6"), "Bucharest", "Romanian leu", "Romania is a country located at the crossroads of Central, Eastern, and Southeastern Europe. It borders on the Black Sea to the southeast, and with Bulgaria to the south, Ukraine to the north, Hungary to the west, Serbia to the southwest, and Moldova to the east. It has a predominantly temperate-continental climate. With a total area of 238,397 square kilometres, Romania is the 12th-largest country in Europe and the 6th most populous member state of the European Union, having approximately 20 million inhabitants. Its capital and largest city is Bucharest. Other major urban areas include: Cluj-Napoca, Timișoara, Iași, Constanța, Craiova, Brașov, and Galați.", "https://restcountries.eu/data/rou.svg", true, "Romania", 19861408L },
                    { new Guid("00016d55-7bbe-4d2a-8c09-5f85e421c476"), "Moscow", "Russian ruble", "Russia, or the Russian Federation, is a transcontinental country located in Eastern Europe and Northern Asia. At 17,125,200 square kilometres (6,612,100 sq mi), it is, by a considerable margin, the largest country in the world by area, covering more than one-eighth of the Earth's inhabited land area, spanning eleven time zones, and bordering 16 sovereign nations. The territory of Russia extends from the Baltic Sea in the west to the Pacific Ocean in the east, and from the Arctic Ocean in the north to the Black Sea and the Caucasus in the south. With 146.7 million inhabitants living in the country's 85 federal subjects, Russia is the most populous nation in Europe and the ninth-most populous nation in the world. Russia's capital and largest city is Moscow; other major urban areas include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, Kazan and Chelyabinsk.", "https://restcountries.eu/data/rus.svg", true, "Russian Federation", 146599183L },
                    { new Guid("d6ad166e-29d0-4ead-9e3f-eadd27b7c42b"), "City of San Marino", "Euro", "San Marino, officially the Republic of San Marino, also known as the Most Serene Republic of San Marino, is an enclave microstate in Southern Europe, on the northeastern side of the Apennine Mountains, completely surrounded by Italy.", "https://restcountries.eu/data/smr.svg", true, "San Marino", 33005L },
                    { new Guid("3a253033-b123-4f7c-9bc1-5abff034c8f9"), "Belgrade", "Serbian dinar", "Serbia, officially the Republic of Serbia, is a landlocked country situated at the crossroads of Central and Southeast Europe in the southern Pannonian Plain and the central Balkans. It borders Hungary to the north, Romania to the northeast, Bulgaria to the southeast, North Macedonia to the south, Croatia and Bosnia and Herzegovina to the west, and Montenegro to the southwest. The country claims a border with Albania through the disputed territory of Kosovo. Serbia's population numbers approximately seven million. Its capital, Belgrade, ranks among the largest citiеs in southeastern Europe.", "https://restcountries.eu/data/srb.svg", true, "Serbia", 7076372L },
                    { new Guid("d8c942a0-feab-4619-8379-86dba9bc41ff"), "Bratislava", "Euro", "Slovakia, officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakia's territory spans about 49,000 square kilometres (19,000 sq mi) and is mostly mountainous. The population is over 5.6 million and consists mostly of Slovaks. The capital and largest city is Bratislava, and the second-largest city is Košice. The official language is Slovak.", "https://restcountries.eu/data/svk.svg", true, "Slovakia", 5426252L },
                    { new Guid("de0867f7-968c-4614-b11f-54ebe298030c"), "Ljubljana", "Euro", "Slovenia, officially the Republic of Slovenia, is a country located in Europe at the crossroads of main European cultural and trade routes. It is bordered by Italy to the west, Austria to the north, Hungary to the northeast, Croatia to the southeast, and the Adriatic Sea to the southwest. Slovenia covers 20,273 square kilometers (7,827 sq mi) and has a population of 2.084 million. One of the successor states of the former Yugoslavia, Slovenia is now a parliamentary republic and member nation of the European Union, United Nations, and NATO. The capital and largest city is Ljubljana.", "https://restcountries.eu/data/svn.svg", true, "Slovenia", 2064188L },
                    { new Guid("952a5bdd-ca6d-4a18-b361-ecfa893f01d4"), "Madrid", "Euro", "Spain, officially the Kingdom of Spain, is a country in Southwestern Europe with some pockets of Spanish territory across the Strait of Gibraltar and the Atlantic Ocean. Its continental European territory is situated on the Iberian Peninsula. Its territory also includes two archipelagoes: the Canary Islands off the coast of Africa, and the Balearic Islands in the Mediterranean Sea. The African enclaves of Ceuta, Melilla, and Peñón de Vélez de la Gomera make Spain the only European country to have a physical border with an African country (Morocco). Several small islands in the Alboran Sea are also part of Spanish territory. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean.", "https://restcountries.eu/data/esp.svg", true, "Spain", 46438422L },
                    { new Guid("cc2c020b-6b1f-4787-820b-0af3c2e1df15"), "Stockholm", "Swedish krona", "Sweden, officially the Kingdom of Sweden, is a Scandinavian country in Northern Europe. It borders Norway to the west and north and Finland to the east, and is connected to Denmark in the southwest by a bridge-tunnel across the Öresund Strait. At 450,295 square kilometres (173,860 sq mi), Sweden is the largest country in Northern Europe, the third-largest country in the European Union and the fifth largest country in Europe by area. The capital city is Stockholm. Sweden has a total population of 10.3 million of which 2.6 million have a foreign background. Persons who have foreign backgrounds are defined as persons who are foreign born, or born in Sweden with foreign born parents. It has a low population density of 22 inhabitants per square kilometre (57/sq mi) and the highest urban concentration is in the central and southern half of the country.", "https://restcountries.eu/data/swe.svg", true, "Sweden", 9894888L },
                    { new Guid("ca4aac75-3b20-4724-b922-5cc58eeaae47"), "Bern", "Swiss franc", "Switzerland, officially the Swiss Confederation, is a country situated in the confluence of Western, Central, and Southern Europe. It is a federal republic composed of 26 cantons, with federal authorities seated in Bern. Switzerland is a landlocked country bordered by Italy to the south, France to the west, Germany to the north, and Austria and Liechtenstein to the east. It is geographically divided among the Swiss Plateau, the Alps, and the Jura, spanning a total area of 41,285 km2 (15,940 sq mi), and land area of 39,997 km2 (15,443 sq mi). While the Alps occupy the greater part of the territory, the Swiss population of approximately 8.5 million is concentrated mostly on the plateau, where the largest cities are located, among them the two global cities and economic centres of Zürich and Geneva.", "https://restcountries.eu/data/che.svg", true, "Switzerland", 8341600L },
                    { new Guid("1cb882f5-50a6-4837-b104-92ff133695dd"), "Kiev", "Ukrainian hryvnia", "Ukraine is a country in Eastern Europe. It is bordered by Russia to the north-east; Belarus to the north; Poland, Slovakia and Hungary to the west; and Romania, Moldova, and the Black Sea to the south. Ukraine is currently in a territorial dispute with Russia over the Crimean Peninsula, which Russia annexed in 2014. Including the Crimean Peninsula, Ukraine has an area of 603,628 km2 (233,062 sq mi), making it the second-largest country in Europe after Russia, and the 46th-largest country in the world. Excluding Crimea, Ukraine has a population of about 42 million, making it the eighth or ninth-most populous country in Europe and the 32nd-most populous country in the world. Its capital and largest city is Kiev. Ukrainian is the official language and its alphabet is Cyrillic. The dominant religion in the country is Eastern Orthodoxy.", "https://restcountries.eu/data/ukr.svg", true, "Ukraine", 42692393L },
                    { new Guid("e24d34a7-cb74-49bc-a2c2-84f164d162ae"), "London", "British pound", "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom or Britain, is a sovereign country located off the north­western coast of the European mainland. The United Kingdom includes the island of Great Britain, the north­eastern part of the island of Ireland, and many smaller islands. Northern Ireland shares a land border with the Republic of Ireland. Otherwise, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to the east, the English Channel to the south and the Celtic Sea to the southwest, giving it the 12th-longest coastline in the world. The Irish Sea separates Great Britain and Ireland. The total area of the United Kingdom is 94,000 square miles (240,000 km2).", "https://restcountries.eu/data/gbr.svg", true, "United Kingdom", 65110000L },
                    { new Guid("995849f4-c234-4fda-bbca-b384a5b397d7"), "Vaduz", "Swiss franc", "Liechtenstein, officially the Principality of Liechtenstein, is a German-speaking microstate situated in the Alps and in the southwest of Central Europe. The principality is a semi-constitutional monarchy headed by the Prince of Liechtenstein; the Prince's extensive powers are equivalent to those of a President in a semi-presidential system.", "https://restcountries.eu/data/lie.svg", true, "Liechtenstein", 37623L },
                    { new Guid("cf1defd6-cebf-4d0a-a155-ec44855d4054"), "Riga", "Euro", "Latvia, officially known as the Republic of Latvia, is a country in the Baltic region of Northern Europe. Since its independence, Latvia has been referred to as one of the Baltic states. It is bordered by Estonia to the north, Lithuania to the south, Russia to the east, Belarus to the southeast, and shares a maritime border with Sweden to the west. Latvia has 1,957,200 inhabitants and a territory of 64,589 km2 (24,938 sq mi). The country has a temperate seasonal climate. The Baltic Sea moderates climate, although it has four distinct seasons and snowy winters.", "https://restcountries.eu/data/lva.svg", true, "Latvia", 1961600L },
                    { new Guid("ff0e9bad-8828-45f8-8e40-1aec6f414fa3"), "Longyearbyen", "Norwegian krone", "Svalbard and Jan Mayen is a statistical designation defined by ISO 3166-1 for a collective grouping of two remote jurisdictions of Norway: Svalbard and Jan Mayen. While the two are combined for the purposes of the International Organization for Standardization (ISO) category, they are not administratively related. This has further resulted in the country code top-level domain .sj being issued for Svalbard and Jan Mayen, and ISO 3166-2:SJ. The United Nations Statistics Division also uses this code, but has named it Svalbard and Jan Mayen Islands.", "https://restcountries.eu/data/sjm.svg", true, "Svalbard and Jan Mayen", 2562L },
                    { new Guid("f4b2238f-92d2-4bcb-97e1-0f4ab914fa14"), "Rome", "Euro", "Italy, officially the Italian Republic, is a European country consisting of a peninsula delimited by the Alps and surrounded by several islands. Italy is located in south-central Europe, and it is also considered a part of western Europe. A unitary parliamentary republic with its capital in Rome, the country covers a total area of 301,340 km2 (116,350 sq mi) and shares land borders with France, Switzerland, Austria, Slovenia, and the enclaved microstates of Vatican City and San Marino. Italy has a territorial exclave in Switzerland (Campione) and a maritime exclave in the Tunisian Sea (Lampedusa). With around 60 million inhabitants, Italy is the third-most populous member state of the European Union.", "https://restcountries.eu/data/ita.svg", true, "Italy", 60665551L },
                    { new Guid("ba22eedb-0038-4fb5-bf29-b4179a4574d8"), "Saint Helier", "British pound", "Jersey, officially the Bailiwick of Jersey, is a British Crown dependency located near the coast of Normandy, France. It is the second-closest of the Channel Islands to France, after Alderney.", "https://restcountries.eu/data/jey.svg", true, "Jersey", 100800L },
                    { new Guid("e59f566b-a7b3-493d-a7e1-eb14fe7f15b0"), "Tirana", "Albanian lek", "Albania, officially the Republic of Albania, is a country in Southeast Europe on the Adriatic and Ionian Sea within the Mediterranean Sea. It shares land borders with Montenegro to the northwest, Kosovo to the northeast, North Macedonia to the east, Greece to the south and maritime borders with Greece, Montenegro and Italy to the west.", "https://restcountries.eu/data/alb.svg", true, "Albania", 2886026L },
                    { new Guid("cb45f420-e051-430c-86e9-9feda99dcd08"), "Andorra la Vella", "Euro", "Andorra, officially the Principality of Andorra, also called the Principality of the Valleys of Andorra, is a sovereign landlocked microstate on the Iberian Peninsula, in the eastern Pyrenees, bordered by France to the north and Spain to the south. Believed to have been created by Charlemagne, Andorra was ruled by the count of Urgell until 988, when it was transferred to the Roman Catholic Diocese of Urgell. The present principality was formed by a charter in 1278. It is known as a principality as it is a diarchy headed by two princes: the Catholic bishop of Urgell in Catalonia, Spain, and the president of the French Republic.", "https://restcountries.eu/data/and.svg", true, "Andorra", 78014L },
                    { new Guid("93bbba4d-854e-450b-be0b-9338a23a4145"), "Minsk", "New Belarusian ruble", "Belarus, officially the Republic of Belarus, formerly known by its Russian name Byelorussia or Belorussia, is a landlocked country in Eastern Europe bordered by Russia to the northeast, Ukraine to the south, Poland to the west, and Lithuania and Latvia to the northwest. Its capital and most populous city is Minsk. Over 40% of its 207,600 square kilometres (80,200 sq mi) is forested. Its major economic sectors are service industries and manufacturing. Until the 20th century, different states at various times controlled the lands of modern-day Belarus, including the Principality of Polotsk, the Grand Duchy of Lithuania, the Polish–Lithuanian Commonwealth, and the Russian Empire.", "https://restcountries.eu/data/blr.svg", true, "Belarus", 9498700L },
                    { new Guid("85955373-cb95-45f5-baa4-cc3187157645"), "Brussels", "Euro", "Belgium, officially the Kingdom of Belgium, is a country in Western Europe. It is bordered by the Netherlands to the north, Germany to the east, Luxembourg to the southeast, France to the southwest, and the North Sea to the northwest. It covers an area of 30,689 km2 (11,849 sq mi) and has a population of more than 11.5 million, making it the 22nd most densely populated country in the world and the 6th most densely populated country in Europe, with a density of 376 per square kilometre (970/sq mi). The capital and largest city is Brussels; other major cities are Antwerp, Ghent, Charleroi and Liège.", "https://restcountries.eu/data/bel.svg", true, "Belgium", 11319511L },
                    { new Guid("de72baa4-5d01-40a8-8662-a1f4bf75e355"), "Sarajevo", "Bosnia and Herzegovina convertible mark", "Bosnia and Herzegovina, abbreviated BiH or B&H, sometimes called Bosnia–Herzegovina and often known informally as Bosnia, is a country of South and Southeast Europe, located within the Balkans. Sarajevo is the capital and largest city.", "https://restcountries.eu/data/bih.svg", true, "Bosnia and Herzegovina", 3531159L },
                    { new Guid("2190eb1a-ed12-4dfe-8b9c-54db07dd6532"), "Sofia", "Bulgarian lev", "Bulgaria, officially the Republic of Bulgaria, is a country in Southeast Europe. It is bordered by Romania to the north, Serbia and North Macedonia to the west, Greece and Turkey to the south, and the Black Sea to the east. The capital and largest city is Sofia; other major cities are Plovdiv, Varna and Burgas. With a territory of 110,994 square kilometres (42,855 sq mi), Bulgaria is Europe's 16th-largest country.", "https://restcountries.eu/data/bgr.svg", true, "Bulgaria", 7153784L },
                    { new Guid("bf515e4d-3094-4e8c-9888-b1e84ab4f948"), "Zagreb", "Croatian kuna", "Croatia, officially the Republic of Croatia, is a country in Southeast Europe. It borders Slovenia to the northwest, Hungary to the northeast, Serbia to the east, Bosnia and Herzegovina, and Montenegro to the southeast, sharing a maritime border with Italy. Its capital, Zagreb, forms one of the country's primary subdivisions, along with twenty counties. Croatia has an area of 56,594 square kilometres and a population of 4.28 million, most of whom are Roman Catholics.", "https://restcountries.eu/data/hrv.svg", true, "Croatia", 4190669L },
                    { new Guid("ed52629d-7e23-4395-832a-a6986461bbab"), "Nicosia", "Euro", "Cyprus, officially the Republic of Cyprus, is an island country in the Eastern Mediterranean and the third-largest and third-most populous island in the Mediterranean, located south of Turkey, west of Syria and Lebanon, north of Israel, the Gaza Strip and Egypt, and southeast of Greece.", "https://restcountries.eu/data/cyp.svg", true, "Cyprus", 847000L },
                    { new Guid("b6d2210d-719c-4d34-98ed-83d2fa86b639"), "Prague", "Czech koruna", "The Czech Republic, also known by its short-form name, Czechia, is a landlocked country in Central Europe bordered by Poland to the northeast, Slovakia to the southeast, Austria to the south, and Germany to the west. The Czech Republic has hilly landscape that covers an area of 78,866 square kilometers (30,450 sq mi) with a mostly temperate continental climate and oceanic climate. It is a unitary parliamentary republic, with 10.7 million inhabitants. Its capital and largest city is Prague, with 1.3 million residents; other major cities are Brno, Ostrava, Olomouc and Pilsen.", "https://restcountries.eu/data/cze.svg", true, "Czech Republic", 10558524L },
                    { new Guid("7e9234ad-c86d-40ee-b1fc-13537408f527"), "Copenhagen", "Danish krone", "Denmark, officially the Kingdom of Denmark, is a Nordic country in Northwest Europe. Denmark proper, which is the southernmost of the Scandinavian countries, consists of a peninsula, Jutland, and an archipelago of 443 named islands, with the largest being Zealand, Funen and the North Jutlandic Island. The islands are characterised by flat, arable land and sandy coasts, low elevation and a temperate climate. The southernmost of the Scandinavian nations, Denmark lies southwest of Sweden and south of Norway, and is bordered to the south by Germany. The Kingdom of Denmark also includes two autonomous territories in the North Atlantic Ocean: the Faroe Islands and Greenland. Denmark has a total area of 42,924 km2 (16,573 sq mi), land area of 42,394 km2 (16,368 sq mi), and the total area including Greenland and the Faroe Islands is 2,210,579 km2 (853,509 sq mi), and a population of 5.8 million in Denmark proper.", "https://restcountries.eu/data/dnk.svg", true, "Denmark", 5717014L },
                    { new Guid("45cfe938-5690-4ed0-bee4-0db49b010985"), "Tallinn", "Euro", "Estonia, officially the Republic of Estonia, is a country on the eastern coast of the Baltic Sea in Northern Europe. It is bordered to the north by the Gulf of Finland with Finland on the other side, to the west by the Baltic Sea with Sweden on the other side, to the south by Latvia (343 km), and to the east by Lake Peipus and Russia (338.6 km). The territory of Estonia consists of the mainland and of 2,222 islands in the Baltic Sea, covering a total area of 45,227 km2 (17,462 sq mi), water 2,839 km2 (1,096 sq mi), land area 42,388 km2 (16,366 sq mi), and is influenced by a humid continental climate. The official language of the country, Estonian, is the second-most-spoken Finnic language.", "https://restcountries.eu/data/est.svg", true, "Estonia", 1315944L },
                    { new Guid("c7bbb690-5992-406b-9519-a16393efbd51"), "Vienna", "Euro", "Austria, officially the Republic of Austria, is a landlocked East Alpine country in the southern part of Central Europe. It is composed of nine federated states (Bundesländer), one of which is Vienna, Austria's capital and its largest city. It is bordered by Germany to the northwest, Czech Republic to the north, Slovakia to the northeast, Hungary to the east, Slovenia and Italy to the south, and Switzerland and Liechtenstein to the west. Austria occupies an area of 83,879 km2 (32,386 sq mi) and has a population of nearly 9 million people. While German is the country's official language, many Austrians communicate informally in a variety of Bavarian dialects.", "https://restcountries.eu/data/aut.svg", true, "Austria", 8725931L },
                    { new Guid("d05cfd98-3d1b-4705-870d-5a2278200ba2"), "Helsinki", "Euro", "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe bordering the Baltic Sea, Gulf of Bothnia, and Gulf of Finland, between Sweden to the west, Russia to the east, Estonia to the south, and north-eastern Norway to the north. The capital and largest city is Helsinki. Other major cities are Espoo, Tampere, Vantaa, Oulu, Turku, Jyväskylä, Lahti and Kuopio.", "https://restcountries.eu/data/fin.svg", true, "Finland", 5491817L },
                    { new Guid("a7f92b47-4ec0-4f21-acfe-3632421d6e34"), "Tórshavn", "Danish krone", "The Faroe Islands, , is a North Atlantic archipelago located 320 kilometres (200 mi) north-northwest of Scotland, and about halfway between Norway and Iceland. It is an autonomous territory within the Kingdom of Denmark. The islands have a total area of about 1,400 square kilometres (540 sq mi) with a population of 51,783 as of June 2019.", "https://restcountries.eu/data/fro.svg", true, "Faroe Islands", 49376L },
                    { new Guid("88125506-773a-4998-88d8-bcd52ca658e5"), "Dublin", "Euro", "Ireland is an island in the North Atlantic. It is separated from Great Britain to its east by the North Channel, the Irish Sea, and St George's Channel. Ireland is the second-largest island of the British Isles, the third-largest in Europe, and the twentieth-largest on Earth.", "https://restcountries.eu/data/irl.svg", true, "Ireland", 6378000L },
                    { new Guid("06798762-636b-4bd9-abb3-2b1f9d68fbb3"), "Budapest", "Hungarian forint", "Hungary is a country in Central Europe. Spanning 93,030 square kilometres (35,920 sq mi) in the Carpathian Basin, it borders Slovakia to the north, Ukraine to the northeast, Romania to the east and southeast, Serbia to the south, Croatia and Slovenia to the southwest, and Austria to the west. With about 10 million inhabitants, Hungary is a medium-sized member state of the European Union. The official language is Hungarian, which is the most widely spoken Uralic language in the world, and among the few non-Indo-European languages to be widely spoken in Europe. Hungary's capital and largest city is Budapest; other major urban areas include Debrecen, Szeged, Miskolc, Pécs, and Győr.", "https://restcountries.eu/data/hun.svg", true, "Hungary", 9823000L },
                    { new Guid("57fa841a-fc01-4440-8e2d-116de92538f9"), "Rome", "Euro", "The Holy See, also called the See of Rome, is the jurisdiction of the Bishop of Rome, known as the pope, which includes the apostolic episcopal see of the Diocese of Rome with universal ecclesiastical jurisdiction of the worldwide Catholic Church, as well as a sovereign entity of international law.", "https://restcountries.eu/data/vat.svg", true, "Holy See", 451L },
                    { new Guid("495c5b51-4515-420b-b9b1-e0340d6c7bb8"), "Reykjavík", "Icelandic króna", "Iceland is a Nordic island country in the North Atlantic, with a population of 364,260 and an area of 103,000 km2 (40,000 sq mi), making it the most sparsely populated country in Europe. The capital and largest city is Reykjavík. Reykjavik and the surrounding areas in the southwest of the country are home to over two-thirds of the population. Iceland is volcanically and geologically active. The interior consists of a plateau characterised by sand and lava fields, mountains, and glaciers, and many glacial rivers flow to the sea through the lowlands. Iceland is warmed by the Gulf Stream and has a temperate climate, despite a high latitude just outside the Arctic Circle. Its high latitude and marine influence keep summers chilly, with most of the archipelago having a polar climate.", "https://restcountries.eu/data/isl.svg", true, "Iceland", 334300L },
                    { new Guid("cd95e0d1-73e9-4893-ab7f-466c06cd92c2"), "Athens", "Euro", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/grc.svg", true, "Greece", 10858018L },
                    { new Guid("a2861a66-c1fd-4253-bd7d-e989c78923e3"), "Gibraltar", "Gibraltar pound", "Gibraltar is a British Overseas Territory located at the southern tip of the Iberian Peninsula. It has an area of 6.7 km2 (2.6 sq mi) and is bordered to the north by Spain. The landscape is dominated by the Rock of Gibraltar at the foot of which is a densely populated town area, home to over 32,000 people, primarily Gibraltarians.", "https://restcountries.eu/data/gib.svg", true, "Gibraltar", 33140L },
                    { new Guid("2286d285-c874-4a84-84a9-0d67bf583b84"), "Berlin", "Euro", "Germany, constitutionally the Federal Republic of Germany, is a country in Central and Western Europe. Covering an area of 357,022 square kilometres (137,847 sq mi), it lies between the Baltic and North seas to the north, and the Alps and Lake Constance to the south. It borders Denmark to the north, Poland and the Czech Republic to the east, Austria and Switzerland to the south, and France, Luxembourg, Belgium, and the Netherlands to the west. With 83 million inhabitants of its 16 constituent states, it is the second-most populous country in Europe after Russia, as well as the most populous member state of the European Union. Its capital and largest city is Berlin, while its largest urban area is the Ruhr. The country's financial capital is Frankfurt; other major cities include Hamburg, Munich, Cologne, and Stuttgart.", "https://restcountries.eu/data/deu.svg", true, "Germany", 81770900L },
                    { new Guid("6f6b375d-9f45-4ad4-aa58-33d65c749c21"), "Paris", "Euro", "France, officially the French Republic, is a country whose territory consists of metropolitan France in Western Europe and several overseas regions and territories. The metropolitan area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. It is bordered by Belgium, Luxembourg and Germany to the northeast, Switzerland and Italy to the east, and Andorra and Spain to the south. The overseas territories include French Guiana in South America and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions span a combined area of 643,801 square kilometres (248,573 sq mi) and a total population of 67.02 million. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban areas include Lyon, Marseille, Toulouse, Bordeaux, Lille and Nice. France, including its overseas territories, has the most number of time zones of any country, with a total of 12.", "https://restcountries.eu/data/fra.svg", true, "France", 66710000L },
                    { new Guid("108a84b9-cbb7-44c2-9f14-74b118f75854"), "St. Peter Port", "British pound", "Guernsey is an island in the English Channel off the coast of Normandy. It lies roughly north of Saint-Malo and to the west of Jersey and the Cotentin Peninsula. With several smaller nearby islands, it forms a jurisdiction within the Bailiwick of Guernsey, a British Crown dependency. The jurisdiction is made up of ten parishes on the island of Guernsey, three other inhabited islands, and many small islets and rocks.", "https://restcountries.eu/data/ggy.svg", true, "Guernsey", 62999L },
                    { new Guid("4a874e36-fab4-4fb5-a74a-dba0fb13d589"), "Douglas", "British pound", "The Isle of Man, also known as Mann, is a self-governing British Crown dependency situated in the Irish Sea between Great Britain and Ireland. The head of state, Queen Elizabeth II, holds the title of Lord of Mann and is represented by a lieutenant governor. The United Kingdom has responsibility for the island's defence.", "https://restcountries.eu/data/imn.svg", true, "Isle of Man", 84497L }
                });

            migrationBuilder.InsertData(
                table: "CountrySpotifyPlaylist",
                columns: new[] { "Id", "CountryId", "PlaylistId" },
                values: new object[,]
                {
                    { new Guid("518825c0-17ed-419a-acc3-5924152deaa4"), new Guid("78322940-9409-41a4-9bac-21d1be36482f"), "6wk61XRax6dMvX3WClLYbH" },
                    { new Guid("8b1a508c-a39e-4f77-b3ca-7ff54b53e6bd"), new Guid("ceed2cd9-7e4e-4bdb-a995-b31b379e7139"), "3ZzdoANeDnNgpPDN8BdL59" },
                    { new Guid("5cb95a95-23b1-48fc-a5c0-61ede947bdde"), new Guid("02a5aed2-135d-41c7-bc64-da9b24871850"), "47dFbcLDn04CX7UorU8Iq8" },
                    { new Guid("0516c480-74d1-401a-91dd-1cf8b4dd9ea9"), new Guid("825e6478-04ff-4185-b639-e3998108cf60"), "3gl4XsDZjDEhP6ENWG0SSm" },
                    { new Guid("b2e1f5d2-99c7-4187-952a-1f94c70dc13c"), new Guid("92b096b0-bdb9-4060-a7df-40e7c2082c40"), "4AJvqhZvRE796GP9RYNrYc" },
                    { new Guid("318443cb-0989-4f9d-b45d-e388995d4313"), new Guid("9a9305f0-1172-4ab4-a5a4-8abe31c08202"), "0FRAi3HnfdGT5Gn69MvYlT" },
                    { new Guid("17940bbf-a09e-434f-9a76-ce4e773e6830"), new Guid("6869d6d4-29a0-4306-a349-e20a4ad7d2b7"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("349a1d32-2846-426b-8e7e-800955d30d47"), new Guid("193e1ed6-bce1-492d-a6eb-e4069760012d"), "29XoM5S9Yc6Heflhp9fIoC" },
                    { new Guid("4dd911f0-5c97-451f-b6e6-4117cb4742bb"), new Guid("0218fb00-203f-4f0e-a9c1-0b70a0bc469f"), "5fpIpFlXUplr5Uy1J1qHnO" },
                    { new Guid("d35db354-ced0-41bd-b1c5-02ef7ba5fc51"), new Guid("d8c942a0-feab-4619-8379-86dba9bc41ff"), "65nrfnJcCxTLsyyjf8WCXe" },
                    { new Guid("e0da32ab-a951-4b19-b22d-f240b1ad213b"), new Guid("00016d55-7bbe-4d2a-8c09-5f85e421c476"), "6d3Zwzras2ghumJvnlIqsI" },
                    { new Guid("03b10037-82c6-4ab2-9a98-e12031261ebb"), new Guid("d6ad166e-29d0-4ead-9e3f-eadd27b7c42b"), "7BSjWFXtpiJxdvzMSBl7Sq" },
                    { new Guid("e34b3593-c3e0-4afe-9f08-870497fadd41"), new Guid("3a253033-b123-4f7c-9bc1-5abff034c8f9"), "1nN2hfHzcXNsVeGAwXev3s" },
                    { new Guid("c46985a8-d7a6-4051-92a7-c4bf6522620a"), new Guid("952a5bdd-ca6d-4a18-b361-ecfa893f01d4"), "1irDloS9VCX40czYAS2klR" },
                    { new Guid("a3f820f6-f001-4b37-aaa3-565eaf38a16e"), new Guid("ff0e9bad-8828-45f8-8e40-1aec6f414fa3"), "6KgYE0tontk4mf54YQfXXS" },
                    { new Guid("cc54683c-52b8-4ca8-8d82-46727208d425"), new Guid("cc2c020b-6b1f-4787-820b-0af3c2e1df15"), "3BeBGfOciz2pHhmMYGF7Qq" },
                    { new Guid("c8825dac-09d8-45a1-aca3-9dd1ff0683b8"), new Guid("ca4aac75-3b20-4724-b922-5cc58eeaae47"), "7KCEnXSAo8e4aHkC3Barql" },
                    { new Guid("cbd309e8-e0f0-4363-bad2-0c9855dcf3a5"), new Guid("c3608a96-7a98-4e67-a1b5-a8629e92752d"), "09TxUze3BuYVNvMY6d418n" },
                    { new Guid("c2a3ac1b-57b0-48a9-a224-fd0481e092c2"), new Guid("1cb882f5-50a6-4837-b104-92ff133695dd"), "5S1GVxkVbKXxoTV8DwBKGi" },
                    { new Guid("9aef17fa-3ebe-458f-a815-2bdea108e5d4"), new Guid("b0312a78-392c-46e9-8cdb-d254165123a6"), "0g5twCr1C6oituq3La2Div" },
                    { new Guid("f5e6e153-6169-4c21-b9f8-1a142b7a29ec"), new Guid("7233d305-0fcb-4395-9da6-cf3288302308"), "12CfDHYf2nkZANtS9f9Vew" },
                    { new Guid("5e3e3200-7493-445c-90fa-a773e40353e6"), new Guid("7e9234ad-c86d-40ee-b1fc-13537408f527"), "7nUxZrzOz1FS67LYqsjdIv" },
                    { new Guid("4f748c60-33c3-44e6-b167-f4f42243fd65"), new Guid("4a874e36-fab4-4fb5-a74a-dba0fb13d589"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("9b3f8449-0a9d-4de1-b216-857d4106e48d"), new Guid("e24d34a7-cb74-49bc-a2c2-84f164d162ae"), "1y7E5GXSac77FzesM2ASjx" },
                    { new Guid("b4cc1942-372c-4a36-b9ca-d7cda89a9b48"), new Guid("c6b84a59-ec04-4fad-8d72-c8a8a77ecbac"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("e915cd7b-d8a0-4335-a618-4b083b039f94"), new Guid("e59f566b-a7b3-493d-a7e1-eb14fe7f15b0"), "7l0CFkcQuUzGolpc36QMIC" },
                    { new Guid("01b51d64-7f17-4ee4-9b28-a321f05c3633"), new Guid("c7bbb690-5992-406b-9519-a16393efbd51"), "53lWeMXMoJ2wWUS1nYnBgl" },
                    { new Guid("18ccbd7d-49a8-43f3-b687-f3d5b14de0e0"), new Guid("93bbba4d-854e-450b-be0b-9338a23a4145"), "5Gu9Cbjqk2MAXo1yY09lCk" },
                    { new Guid("d910bd9d-bd9f-4519-b481-3e74966a3102"), new Guid("85955373-cb95-45f5-baa4-cc3187157645"), "50AOO2iX1bfP12JDe2cSAN" },
                    { new Guid("8a944c8a-b1fe-4301-8b21-e93c16a29ab5"), new Guid("2190eb1a-ed12-4dfe-8b9c-54db07dd6532"), "6DpX8j1kTO55ZazVWIUJ9H" },
                    { new Guid("ecd2d135-53af-46d1-b5be-87c09a28059e"), new Guid("bf515e4d-3094-4e8c-9888-b1e84ab4f948"), "0LexRqlNAFHzIG3upGcA0S" },
                    { new Guid("dbaad6c0-307f-4ab3-bcd9-843bf75f6d45"), new Guid("ed52629d-7e23-4395-832a-a6986461bbab"), "0T73gC6LcZuhHfxuhTUSd5" },
                    { new Guid("eb5dfd22-3d3f-4315-9e66-2ed56e12feeb"), new Guid("f4b2238f-92d2-4bcb-97e1-0f4ab914fa14"), "0ylcsCmX0r03zT9yISmFWp" },
                    { new Guid("b1f0ab9f-acaa-4e50-a461-c522e2136b1c"), new Guid("b6d2210d-719c-4d34-98ed-83d2fa86b639"), "253ARKQpYyLw3VYbIiy2zn" },
                    { new Guid("39c14ed8-257f-4360-b4d2-81d5dc504594"), new Guid("a7f92b47-4ec0-4f21-acfe-3632421d6e34"), "5EC6uJxihNWkD5ZlYXKpL5" },
                    { new Guid("8f426bee-d749-4f8a-8cbd-62b1466f01dd"), new Guid("d05cfd98-3d1b-4705-870d-5a2278200ba2"), "2CusBjVWAtRWy0L5BfmikW" },
                    { new Guid("1d0bbf92-0638-4c9a-8175-204c2bac5cfa"), new Guid("6f6b375d-9f45-4ad4-aa58-33d65c749c21"), "0QgtRvswo2Ugn0B1MTHQkW" },
                    { new Guid("12cc2b61-636f-4ffe-92f3-a8486d0165a4"), new Guid("2286d285-c874-4a84-84a9-0d67bf583b84"), "7Cdk1T18F4mJKNPJxmP8o3" },
                    { new Guid("4d82aa8c-66f1-4724-a1ed-5ed1fb4fe4fc"), new Guid("a2861a66-c1fd-4253-bd7d-e989c78923e3"), "30EHPgCW4KRgOR4VumFHfs" },
                    { new Guid("ae5625de-fc78-4dbe-a156-4fb0b84fe7d0"), new Guid("cd95e0d1-73e9-4893-ab7f-466c06cd92c2"), "1s8ckUBY7ZZjrJMPZ4BtOj" },
                    { new Guid("1df5afa9-131c-48c6-9857-588455e3dff4"), new Guid("06798762-636b-4bd9-abb3-2b1f9d68fbb3"), "7LsbwkqPWuIVjM8OmqJyJh" },
                    { new Guid("c1c30e7a-b09d-4c5f-9a5e-b2c03c42bb64"), new Guid("495c5b51-4515-420b-b9b1-e0340d6c7bb8"), "2dvjKJLYeizywy2NQiKlVO" },
                    { new Guid("946bcd1b-11e1-4829-8268-dc92e5259913"), new Guid("88125506-773a-4998-88d8-bcd52ca658e5"), "2zesk6vpZhemqH9FbZKZnq" },
                    { new Guid("fd7cb5ea-f84d-4aab-9ecb-85eda19e9a45"), new Guid("45cfe938-5690-4ed0-bee4-0db49b010985"), "1ObBKzabSHf6WD4VZI8fJU" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5311214-564f-4824-ba65-b57042349e49"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEJSAGof0B6uh4sR49NlabVtKK0ENLv7kKjfG8nltHG9m7XrgohDIsTIQskMBn2Wk1w==");

            migrationBuilder.CreateIndex(
                name: "IX_CountryWishlists_CountryId",
                table: "CountryWishlists",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavourites_Countries_CountryId",
                table: "UserFavourites",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavourites_Favourites_FavouriteId",
                table: "UserFavourites",
                column: "FavouriteId",
                principalTable: "Favourites",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
