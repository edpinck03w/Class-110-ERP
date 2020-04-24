function Car(make, model, year, color, price, mileage, mpg, image, seats, condition){
    this.make = make;
    this.model = model;
    this.year =year;
    this.color = color;
    this.price = price;
    this.mileage = mileage;
    this.mpg = mpg;
    this.image = image;
    this.seats = seats;
    this.condition = condition;
}

function clearForm(){
    $("#textMake").val("");
    $("#textModel").val("");
    $("#textYear").val("");
    $("#textColor").val("");
    $("#textPrice").val("");
    $("#textMileage").val("");
    $("#textMPG").val("");
    $("#textSeats").val("");
    $("#selectCondition").val("");
    $("#textImage").val("");
}

function registerCar(){
    //get variables
    var make = $("#textMake").val();
    var model = $("#textModel").val();
    var year = $("#textYear").val();
    var color = $("#textColor").val();
    var price = $("#textPrice").val();
    var mileage = $("#textMileage").val();
    var condition = $("#selectCondition").val();
    var seats = $("#textSeats").val();
    var mpg = $("#textMPG").val();
    var image = $("#textImage").val();

    var priceNumber = 0;
    if(price){
        priceNumber = parseFloat(price);
    }

    var yearNumber = 0;
    if(year){
        yearNumber = parseInt(year);
    }

    var seatsNumber = 0;
    if(seats){
        seatsNumber = parseInt(seats);
    }

    var mileageNumber = 0;
    if(mileage){
        mileageNumber = parseInt(mileage);
    }

    var mpgNumber = 0;
    if(mpg){
        mpgNumber = parseInt(mpg);
    }
    //create an object - the order of the variables in Car() must reflect the order of line 1 to get the data to match
    var car = new Car(make, model, yearNumber, color, priceNumber, mileageNumber, mpgNumber, image, seatsNumber, condition);
    console.log(car);
    console.log("btn clicked");

    // send the object on AJAX req
    $.ajax({
        url: '/catalog/saveCar',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(car),
        success: function(res){
            console.log("Server responded", res);
            clearForm();    
        },
        error: function(detail){
            console.log("Error on request", detail);
        }
    })
}

function init(){
    console.log("Register Page!");

    $("#btnSave").click(registerCar);

}

window.onload = init;