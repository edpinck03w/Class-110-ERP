
function retrieveCatalog(){
    // url: /catalog/getCatalog
    $.ajax({
        url: '/catalog/getCatalog',
        type: 'GET',
        success: function(res){
            console.log("Server responded", res);
            console.warn("Server responded", res);
            //display cars on the HTML
            for(let i=0; i < res.length; i++){
                displayCar(res[i]);
            }
            clearForm(); 
        },
        error: function(detail){
            console.log("Error on request", detail);
            console.error("Error on request", detail);
        }
    })



}
function displayCar(car){
    //get container
    var container = $("#catalog");

    //crete template/syntax
    var sntx = 
    `<div class='item'>
        <img src="${car.image}">
        <h4>${car.make}</h4>
        <h4>$ ${car.price}</h4>
        <h5>Vehicle Condition Description:</h5>
        <h5>Enjoy a limited time offer in this ${car.year} ${car.color} ${car.model}. This vehicle has a miles per gallon range of ${car.mpg} in suburban areas with a milegae of ${car.mileage}. With the ability to seat up to ${car.seats} passengers comfortably.The current condition is ${car.condition}</h5>
               
    </div>`;
    
    /*
    `<div class="item" id="${product.code}">
    <img src="${product.image}">
    <h4 class="item-title">${product.title}</h4>
    <h6 class="item-price">${product.price}</h6>
    <p> ${product.description}</p>
    <div class="button-div">
        <button class="btn btn-primary mb-2">Add to the Cart</button>
    </div>
</div>`*/

    //add template to container
    container.append(sntx);
}

function init(){
    console.log("Catalog page!");
    //get data
    retrieveCatalog();
    //hooks events

}

window.onload = init;