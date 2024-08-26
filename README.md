# Sims2HTMLExporter
 Transform a SimPE exported neighborhood into an HTML website directory for The Sims 2
 This is currently a proof of concept.

 Download the latest executable release [here](https://github.com/HatfulBob/Sims2HTMLExporter/releases/tag/release)

 ## Instructions how to use
 1. First, you need to extract your neighborhood from SimPE. Open SimPE, at the top of the screen select the Tools -> Neighborhood -> Export Neighbourhoods. When done, select a folder where you want your exported neighborhood to be and then finally select the neighborhood you want to export. Click 'Open', bottom left for -File Type select .csv then click "Apply". When it's ready, you're ready to use this tool!
 2. Run the Sims2HTMLExporter
 3. Click 'Browse...', then select the 'ExportedSims.csv'. If successful, your neighborhood name should show up under 'Neighborhood Name' and there should be the message 'Neighborhood parsed!'
 4. Click 'Image Folder...', then select the 'SimImage' folder.
 5. Click 'Export Folder...', then select a folder for your HTML website to be outputted (ideally an empty one, but can overwrite a pre-existing generation from this application without issue).
 6. Click 'Generate!'. If successful, a small window will appear saying it was successful
 7. Navigate to the folder you had selected previously to export, then click the 'index.html' to start browsing.

## Todo
There's a lot of information still missing that can be parsed. Some more ambitious ideas, such as family tree visualisation, may be considered.
- Lot information (pages for lots, perhaps Sim pages saying where they live exactly)
- Filtering options on homepage (probably put it all in a Datatables table)
- More images (such as aspiration icons or skill bars)
- Personality information
- Skills information
- Interests information
- Nicer formatting

## Credits
For CSS, just uses Bootstrap [https://getbootstrap.com/](https://getbootstrap.com/)
The Sims 2 and all Sims stuff is copyright Maxis and Electronic Arts. All rights reserved

 
