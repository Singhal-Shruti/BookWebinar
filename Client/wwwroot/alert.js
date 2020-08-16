function Alert(message) {
           alert(message);
}

function setElementById(id, text){
    document.getElementById(id).innerText = text;
}

function getPassCode(maxValue){
    DotNet.invokeMethodAsync('Client', 'GeneratePassCode', maxValue)
          .then(result => {
              setElementById("passCodeSpan", result)
          });
}