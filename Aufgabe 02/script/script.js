var ApiKey = '598ae4d3cb3df33fbc37b7fbb43d1844'

window.onload = startUp;

function startUp()
{	  
   document.getElementById("bt_search").addEventListener("click",searchLocation);
   document.getElementById("form_input").addEventListener("submit",handleInputEnter);

   getPosition();
}

function handleInputEnter(event)
{
   event.preventDefault();
   searchLocation();
}

function searchLocation()
{
   var place = document.getElementById('in_place').value;
   document.getElementById('in_place').value = '';
   getWeatherFromName(place);
}

function getPosition()
{
   if(navigator.geolocation) 
   {
      navigator.geolocation.getCurrentPosition(getCityName);
   }
}

function getCityName(position)
{
   fetch('http://api.openweathermap.org/geo/1.0/reverse?lat='+ position.coords.latitude + '&lon=' + position.coords.longitude + '&limit=1&appid=' + ApiKey)
   .then(function(resp) { if(resp.ok) {return resp.json();}  })
   .then(function(data) { getWeatherFromName(data[0].name);  })
}

function getWeatherFromName(cityname)
{
   fetch('http://api.openweathermap.org/data/2.5/weather?q=' + cityname + '&appid=' + ApiKey)
   .then(function(resp) { if(resp.ok) {return resp.json()} })
   .then(function(data) { updatePage(data);                })
}

function updatePage(data)
{
   document.getElementById('temp').textContent      = (data.main.temp - 273.15).toFixed(2);
   document.getElementById('pressure').textContent  = (data.main.pressure).toFixed(0);
   document.getElementById('humidity').textContent  = (data.main.humidity).toFixed(0);
   document.getElementById('temp_min').textContent  = (data.main.temp_min - 273.15).toFixed(2);
   document.getElementById('temp_max').textContent  = (data.main.temp_max - 273.15).toFixed(2);
   document.getElementById('speed').textContent     = (data.wind.speed).toFixed(2);
   document.getElementById('direction').textContent = (data.wind.deg).toFixed(0);

   document.getElementById('location').textContent  = data.name + ', ' + data.sys.country;
   document.getElementById('short_description').textContent = data.weather[0].description;
   document.getElementById('weather_icon').src = 'http://openweathermap.org/img/wn/' + data.weather[0].icon + '.png'
}