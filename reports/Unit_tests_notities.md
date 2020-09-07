# Unit tests

## Introductie
Dit document bevat alle unit tests in het dit project voor [WorldExplorerEurope.App](https://github.com/howest-gp-imi/st-1920-2-S3-project-gaslam/tree/master/src/WorldExplorerEurope/WorldExplorerEurope.App).

Deze tests worden onderverdeeld in verschillende klassen. Dit document ook zo volgens Klassenaam(titel) en Methodenaam(subtitel) ingedeeld.

## LoginViewModel

### LoginCommand_returns_User

Om de alle functionaliteit van deze app te benutten heb je een account nodig. Het is ook dus belangrijk dat de login methode getest word.

### LoginCommand_Validates_UserEmail

Het mailadress moet correct en mag ook niet null zijn.

### LoginCommand_Validates_Password

Het wachtwoord mag niet null zijn.

## MainViewModel

### GetCountries_returns_NotNullList

In deze test wordt de GetCountries methode aangesproken om te kijken of hij wel een lijst van landen weergeeft.

### GetCountries_returns_Country

In deze test wordt de OnFilterChanged methode aangesproken om te kijken of hij wel een lijst van landen weergeeft.

### LocationCommand_returns_Location

Om dit uit te voegen gaat hij het LocationCommand eerst uitvoeren Daarnaast gaat hij het land via de variabelen expected en actual vergelijken.

## RegisterViewModelTests

### RegisterCommand_Saves_CreatedInstance

Natuurlijk moet de gebruikersgegevens correct ingegeven worden. Die methode test aan de hand van de correcte gegevens of er geregistreerd kan worden.

### RegisterCommand_Validates_CreatedInstanceNames

Deze methode gaat controleren of de namen van de nieuwe gebruiker ingegeven zijn. Daarna vergelijkt hij de foutberichten.

### RegisterCommand_Validates_CreatedInstanceEmail

Deze methode gaat controleren of de email van de gebruiker ingegeven of correct is. Daarna vergelijkt hij de foutberichten.

### RegisterCommand_Validates_CreatedInstanceNationality

Natuurlijk moet ook de nationaliteit van de gebruiker gecontroleerd worden.

### RegisterCommand_Validates_CreatedInstanceBirthDate

Een computer kan de gebruiker ook niet zien wanneer hij geen camera heeft met gezichtsherkenning. Dus word hier nagekeken of de geboortedatum correct is ingevuld. Deze test slaagt als de geboortedatum niet ik de toekomst ligt of de gebruiker 12 jaar of ouder is.

### RegisterCommand_Validates_CreatedInstancePassword

Beveiliging is van groot belang dus wordt hier ook gekeken of het wachtwoord klopt. Deze test slaagt als alle foutmeldingen kloppen.