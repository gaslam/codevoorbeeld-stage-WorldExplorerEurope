# World Explorer Europe

## Project
World Explorer: Europe is een applicatie die info geeft over alle landen van Europa. Ik heb Europa eerst gekozen omdat ik tijdens de werkperiode genoeg tijd moet besteden aan de applicatie en alles erond. Moest ik andere continenten erbij doen, ging er te veel werk bijkomen. De app haalt zijn info via het internet van zowel een eigen database en andere bronnen. Die info bestaat uit het volgende:

-	De naam van het gekozen land;
-	Een foto met de vlag die hij van restcountries.eu haalt;
-	Een korte beschrijving door wikipedia of een eigen tekst;
-	Enkele korte weetjes over het land zoals bv. lidmaatschap van de EU. Die info haalt hij ook via restcountries.eu;
-	Een lijst met enkele typische nummers uit dat land via een afspeelijst op spotify;
-	Een collectie foto’s van de gebruiker zelf.

Het is ook de bedoeling dat de database beheert wordt door een administrator via een externe website. De bewerkingen gaan dan via internet langs een web api(application programming interface) naar de database. 

## Extra info voor stagebedrijven die dit nu kijken

De app is zowel beschikbaar via UWP en Android. Heb enkel op UWP getest de laatste tijd, maar Android zal normaalgezien ook werken. Om zoveel mogelijk bugs te vermijden zou ik best voor de dev branch kiezen. In de originele repo mocht alleen gemerged worden naar de master, wanneer de leerkrachten het goedkeurden.

Alle keys van de vorige commits zijn niet meer geldig.

Ook zal je in de app een foutmelding krijgen over de syncfusion key die niet meer geldig is. Die mag je gewoon negeren.

### Spotify

In in de Services folder van de api voeg je je client en secret toe van jouw applicatie in de spotify klasse.

Buiten dat voer je ook het ipconfig commando via het command venster.

Kopieer uw ipv4 adres op het lokale netwerk en vervang alles tussen de haakjes van de variable BaseUrl (WorldExplorerEurope.app => Domain => Services => API => WorldExplorerAPIService).

### OpenCage

Voor de locatie te bepalen ging ik normaalgezien gebruik maken van de google maps api, maar dat kost wel wat geld en dat ga ik dus natuurlijk niet uitgeven. Daarom koos ik voor het gratis alternatief [OpenCage](https://opencagedata.com).

In in de domain folder in het gemeenschappelijk project van de app voeg je de via de services de api key toe.
