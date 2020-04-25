
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
    <div class="card text-center ">
    <div class="card-header">
      Available For Purchase
    </div>
    <div class="card-body">
      <h5 class="card-title">Vehicle Condition Description:</h5>
      <span class="border border-light size"><img src="${car.image}" class="rounded"></span>
        <h4>${car.year}  ${car.make}  ${car.model}</h4>
        <h4>$ ${car.price}</h4>
        <h5></h5>
        <hr>
        <p class="card-text text-wrap">Enjoy a limited time offer in this ${car.year} ${car.color} ${car.make} ${car.model}. This vehicle has a ${car.mpg} miles per gallon range in city and suburban areas with a current odometer mileage reading of ${car.mileage} miles. Current interior storage capacity allows this ${car.make} ${car.model} the ability to seat up to ${car.seats} passengers comfortably. And the current condition is rated as ${car.condition} by our certified inspectors.</p>
        <hr>
        <h5></h5>
        </div>
        <div class="card-footer text-muted">
        <button type="button" class="btn btn-primary btn-lg btn-block">Select Listed Vehicle</button>  
        </div>
    </div>
    
    </div>`;
    

    
    
    
      
      
    
    
      
    
  

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