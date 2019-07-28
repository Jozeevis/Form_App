# Form App
Dit project is gemaakt als assessment voor een sollicitatie. Het kostte me in totaal ongeveer 3.5 uur.

## Prerequisites
De solution is gemaakt in Visual Studio 2019 als .NET Core 2.1 project. 
Er wordt gebruik gemaakt van een lokale instantie van SQL Express als database.
Mocht het zijn dat er een andere database gebruikt moet worden kan de connectionstring in appsettings.json worden aangepast naar de gewenste database.

## Toelichting
Mijn aanpak begon bij het maken van een nieuw .NET Core project en zoveel mogelijk pagina's waarvan ik zeker wist dat ze niet nodig waren te verwijderen.
Daarna ben ik begonnen aan het model voor het formulier, aangezien het gegeven informatie was welke velden hier in moesten staan.
Hierbij heb ik ook meteen de validatieregels opgezet, inclusief het aanmaken van de RequireTrue klasse om de checkbox voor de algemene voorwaarden te controlleren.
Vanaf daar ben ik het formulier zelf gaan maken, eerst de view en daarna de controller.
De volgende stap was een plek hebben om de entries in op te slaan, zodat de controller hier naar kon verwijzen. 
Ik had besloten om een database te gebruiken, en contact met de database een aparte klasse te doen (FormEntryManager) om functionaliteit zo veel mogelijk te scheiden van de presentatie.
Zodra ik hier de benodigde functies had aangemaakt (GetAllEntries, Create en Delete) ben ik de database zelf op gaan zetten.
Ik heb hierbij gekozen voor SQL Express omdat ik deze al lokaal had draaien, en ik hier het meest mee bekend was.
Toen ik het formulier eenmaal had werken, en de entries in de database zag verschijnen, ben ik begonnen aan de overige functionaliteit: het tonen en verwijderen van entries.
Eerst heb ik een partial view gemaakt voor het tonen van de entries, en hierbij de IndexController aangemaakt die het ophalen van de entries regelde.
Daarna heb ik de mogelijkheid toegevoegd om deze entries te verwijderen uit de lijst, en gezorgd dat de controller hier goed mee omging.
Tot slot heb ik nog enkele messages toegevoegd die aan de gebruiker worden getoond als er bepaalde acties gebeuren die niet direct duidelijk zijn, zoals het aanmaken en verwijderen van entries.

## Moeilijkheden
De grootste struikelblokken waren het opzetten van de database en de routing goed laten verlopen.

Het probleem met het opzetten van de database kwam met name uit mijn gebrek aan ervaring met EntityFramework in .NET Core.
Voor het opzetten hiervan volgde ik een tutorial uit de microsoft documentatie, maar de connectie met de database werkte niet direct.
Ik heb de problemen eerst proberen te googlen, maar hier kwam ik niet veel verder mee, omdat de antwoorden die ik vond over andere stappen gingen dan waar bij mij de fout lag.
Uiteindelijk heb gekeken naar andere projecten waar ik toegang toe had die gebruik maakten van EntityFramework, en zo kon ik de juiste configuratie maken zodat de database werkte.

Mijn moeilijkheden met de routing kwamen ook grotendeels uit mijn gebrek aan ervaring met .NET Core, specifiek Razor Pages.
Met name toen ik de IndexController aan had gemaakt, en deze als default controller wilde instellen, werkte dit in eerste instantie niet.
Uiteindelijk bleek dat Visual Studio in het standaard project de '@page' directive had toegevoegd aan mijn Index view, waardoor deze als standaard werd gebruikt.
Door een combinatie van googlen naar de fout en het debuggen van mijn applicatie vond ik uiteindelijk dit probleem, en kon ik het makkelijk oplossen.
