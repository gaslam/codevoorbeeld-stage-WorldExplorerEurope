# World Explorer Europe

## Project
World Explorer: Europe is een applicatie die info geeft over alle landen van Europa. Ik heb Europa eerst gekozen omdat ik tijdens de werkperiode genoeg tijd moet besteden aan de applicatie en alles erond. Moest ik andere continenten erbij doen, ging er te veel werk bijkomen. De app haalt zijn info via het internet van zowel een eigen database en andere bronnen. Die info bestaat uit het volgende:

-	De naam van het gekozen land;
-	Een foto met de vlag die hij van [restcountries.eu](http://restcountries.eu/) haalt;
-	Een korte beschrijving door wikipedia of een eigen tekst;
-	Enkele korte weetjes over het land zoals bv. lidmaatschap van de EU. Die info haalt hij ook via restcountries.eu;
-	Een lijst met enkele typische nummers uit dat land via een afspeelijst op spotify;
-	Een collectie foto’s van de gebruiker zelf.

Het is ook de bedoeling dat de database beheert wordt door een administrator via een externe website. De bewerkingen gaan dan via internet langs een web api(application programming interface) naar de database. 

## Extra info
### Extra info voor stagebedrijven die dit nu kijken

Dit project bestaat uit:

- Een website(gemaakt met ASP.NET Core Web App en Vue.js);
- Een Web API(gemaakt met ASP.NET Core Web Api);
- Een App(Gemaakt met Xamarin.Forms).

Dit project moest ik doen voor het examen van 3 vakken:

- Mobile Development (voor Xamarin.Forms);
- Programming Innovation (voor programmeertechnologieën zoals SignalR en Swagger);
- Programming Integration (voor ASP.NET Core Web Api);

De app is zowel beschikbaar via UWP en Android. De laatste dagen heb ik enkel via UWP getest, maar Android zal normaalgezien ook werken. De app is jammer genoeg niet reponsive in Android dus is het aangeraden om via een Android Emulator een gsm te gebruiken met een resolutie van 1440 x 2560. De volgende keer zal ik daar beter opletten.

Om zoveel mogelijk bugs te vermijden zou ik best voor de dev branch kiezen. In de originele repo mocht alleen gemerged worden naar de master, wanneer de leerkrachten het goedkeurden.

Alle keys van de vorige commits zijn niet meer geldig.

Ook zal je in de app een foutmelding krijgen over de syncfusion key die niet meer geldig is. Die mag je gewoon negeren.

Meer info vind u in de [documentatie](https://github.com/gaslam/codevoorbeeld-stage-WorldExplorerEurope/blob/dev/reports/EE%20Gaspard.pdf). Ga naar reports/EE_Gaspard.pdf.

Natuurlijk zijn hier en daar wat punten waarop ik kan verbeteren, maar ben voor alle vakken van dit project geslaagd.

### Spotify

In in de Services folder van de api voeg je je clientId en secret toe van jouw applicatie in de spotify klasse. Die krijg je door het aanmaken van een  developer app via [developer.spotify.com](https://developer.spotify.com/)

Buiten dat voer je ook het ipconfig commando via het command venster.

Kopieer uw ipv4 adres op het lokale netwerk en vervang alles tussen de haakjes van de variable BaseUrl (WorldExplorerEurope.App => Domain => Services => API => WorldExplorerAPIService).

### OpenCage

Voor de locatie te bepalen ging ik normaalgezien gebruik maken van de google maps api, maar dat kost wel wat geld en dat ga ik dus natuurlijk niet uitgeven. Daarom koos ik voor het gratis alternatief [OpenCage](https://opencagedata.com).

In in de domain folder in het gemeenschappelijk project van de app voeg je de via de services de api key toe.
