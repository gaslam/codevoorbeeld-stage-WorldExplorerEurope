# World Explorer Europe

## Project
World Explorer: Europe is een applicatie die info geeft over alle landen van Europa. Ik heb Europa eerst gekozen omdat ik tijdens de werkperiode tijd moet besteden aan de applicatie en alles erond. De app haalt zijn info via het internet van zowel een eigen database en andere bronnen. Die info bestaat uit het volgende:

-	De naam van het gekozen land;
-	Een foto met de vlag die hij van restcountries.eu haalt;
-	Een korte beschrijving door wikipedia of een eigen tekst;
-	Enkele korte weetjes over het land zoals bv. lidmaatschap van de EU. Die info haalt hij ook via restcountries.eu;
-	Een lijst met enkele typische nummers uit dat land via een afspeelijst op spotify;
-	Een collectie foto’s van de gebruiker zelf.

Het is ook de bedoeling dat de database beheert wordt door een administrator via een externe website. De bewerkingen gaan dan via internet langs een web api(application programming interface) naar de database. 

## Extra info

### Spotify

In in de Services folder van de api voeg je de volgende keys in de spotify klasse toe:

- clientId:
```
e1e36ceac985420e9c65c12f450045da
```

- secretId:
```
5d151d54fa7a4be9a5d473201f072ea5
```

Buiten dat voer je ook het ipconfig commando via het command venster.

Kopieer uw ipv4 adres op het lokale netwerk en vervang alles tussen de haakjes van de variable BaseUrl (WorldExplorerEurope.app => Domain => Services => API => WorldExplorerAPIService).

### OpenCage

Voor de locatie te bepalen ging ik normaalgezien gebruik maken van de google maps api, maar dat kost wel wat geld en dat ga ik dus natuurlijk niet uitgeven. Daarom koos ik voor het gratis alternatief [OpenCage](https://opencagedata.com).

In in de domain folder in het gemeenschappelijk project van de app voeg je de via de services de volgende key in de OpenCage klasse toe:

- OpenCage API Key:
```
d41c893d59b24581ac5b1596decc612b
```
