chrome.runtime.onMessage.addListener(function(request, sender) {
	console.log("addListener loaded"); 
  if (request.action == "getSource") {
    message.innerText = request.source;
  }
});

document.getElementById("yes").addEventListener('click', onWindowLoad);

document.getElementById("no").addEventListener('click', onWindowLoad);


function onWindowLoad() {
	
  var message = document.querySelector('#message');
	console.log("onWindowLoad loaded");   
  chrome.tabs.executeScript(null, {
    file: "getPagesSource.js"
  }, function() {
    // If you try and inject into an extensions page or the webstore/NTP you'll get an error
    if (chrome.runtime.lastError) {
      message.innerText = 'There was an error injecting script : \n' + chrome.runtime.lastError.message;
    }
  });
  console.log("onWindowLoad loaded");
  //alert("My First Jquery Test");
}

//window.onload = onWindowLoad;