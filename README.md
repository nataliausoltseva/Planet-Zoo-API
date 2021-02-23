# Planet-Zoo-API

Run the program and go to the [https://localhost:44380/index.html](https://localhost:44380/index.html)

This API has 2 endpoints: 
- [https://localhost:44380/api/Animals](https://localhost:44380/api/Animals)
- [https://localhost:44380/api/HabitatEnrichments](https://localhost:44380/api/HabitatEnrichments)

The structure of Animals response:
```json 
{
  "id":0,
  "species":"",
  "species_ID":"",
  "interactivity":"",
  "social":{
    "group_size":"",
    "male":"",
    "female":""
   },
  "reproduction":{
    "maturity":"",
    "incubation":"",
    "interbirth":0
   },
  "continents":"",
  "conservation_status":"",
  "habitat":{
    "land_area":"",
    "land_area_for_additional_animal":"",
    "water_area":"",
    "water_area_for_additional_animal":"",
    "climbing_area":"",
    "climbing_area_for_additional_animal":"",
    "temperature":"",
    "humidity":"",
    "biomes":[
      {
        "biome":""
      }
     ]
  },
  "population":"",
  "edition":"",
  "shared_habitat":[
    {
      "animal":""
    }
  ]
}
```

The strucutre of the HabitatEnrichment repsonse:
```json
{
  "name":"",
  "cost":"",
  "type":"",
  "animals:[
    {
      "species":""
    }
  ]
}
```
