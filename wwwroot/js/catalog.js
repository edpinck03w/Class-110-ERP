
function retrieveCatalog(){
    // url: /catalog/getCatalog
    $.ajax({
        url: '/catalog/getCatalog',
        type: 'GET',
        success: function(res){
            console.log("Server responded", res);
            console.warn("Server responded", res);
            //display cars on the HTML
        },
        error: function(detail){
            console.log("Error on request", detail);
            console.error("Error on request", detail);
        }
    })



}


function init(){
    console.log("Catalog page!");
    //get data
    retrieveCatalog();
    //hooks events

}

window.onload = init;