Notes: 
1.	Run the soluiton
2. The home page is showing a datatable, which is loaded with the reconciled data from two virual data tables 
3. As the data source is not known, two JSON files emulate independent data stores. The files: Event.json and Person.json are stored in App_Data folder 
2.	API Controller added to emulate an independent source of data

Questions and Answers:

1.	If you had more time, what would you change or focus more time on?

Depends on the part I was asked to work. For example: 
a)	If the data source is accessible, I would optimise data at the source the reduce bandwidth and processing time
b)	API security to protect the data as I would believe that clinical data are highly confidential  
c)	Currently the UI page is refreshed on timer. Ideally I’d use SignalR to push data to client 
d)	Certainly better UI (better ajax utilisation to update only what you need), better error handling, better comments 

2.	Which part of the solution consumed the most amount of time?
API controller 

3.	To add filtering, sorting, data pagination. This will improve UI and reduce bandwidth 


