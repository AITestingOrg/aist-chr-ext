chrome.runtime.onMessage.addListener(function(request, sender) {
    
  console.log(sender.tab ?
    "from a content script:" + sender.tab.url :
    "from the extension");

  if (request.action == "getSource") {

    message.innerText = "Processing... Please wait..."; //request.source"";

    var pageData = "Url=" + sender.tab.url +"&HtmlString="+ encodeURIComponent(request.source) +"&PageType=Login";

    loadXMLDoc(pageData, function(fetchResult) {
           if (fetchResult != "noquery")            
            message.innerText = "Data saved";
           else            
            message.innerText = "Unable to save data! Contact your administrator.";
         });
         return true; // See the description of https://developer.chrome.com/extensions/extension.html#property-onMessage-sendResponse.
  }
});

getPageData()

document.getElementById("yes").addEventListener('click', getPageData);

document.getElementById("no").addEventListener('click', doNothing);

function getPageData() {
	
  var message = document.querySelector('#message');
  
  chrome.tabs.executeScript(null, {
    file: "getPagesSource.js"
  }, function() {
    // If you try and inject into an extensions page or the webstore/NTP you'll get an error
    if (chrome.runtime.lastError) {
      message.innerText = 'There was an error injecting script : \n' + chrome.runtime.lastError.message;
    }
  });
}

function doNothing(){
  message.innerText = "Nothing was saved";
}

function loadXMLDoc(parameters, callback)
{
  // debugger;
    if (parameters){
    // new cross origin XML request

    xmlhttp=new XMLHttpRequest();

    // xmlhttp.onreadystatechange=function()
    //  {
    //   if (xmlhttp.readyState==4)
    //    {
    //       if(xmlhttp.status==200)
    //       {
    //         fetchResult = JSON.parse(xmlhttp.responseText);
    //         callback(fetchResult);
    //       } else {
    //         callback("noquery");
    //       }
    //    }
    //   }

    xmlhttp.open("PUT","http://localhost:63762/API/AIST", true); 
    xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlhttp.onreadystatechange = function() {//Call a function when the state changes.
      if(xmlhttp.readyState == XMLHttpRequest.DONE && xmlhttp.status == 200) {          
          callback("saved");    
      }else
      {        
        callback("noquery");
      }
    }
    xmlhttp.send(parameters);

    } else {

        callback("noquery");
    }
};