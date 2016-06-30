//Create a variable called msg to hold a new message
var msg = "Sign up to receive our newsletter for 10% off!";

//Create a funciton to update the content of the element  whose id attribute has a value message
function updateMessage() {

	var el = document.getElementById('message');

	el.textContent = msg;
}

//Callout the function
updateMessage();

var msg1 = "3 Things I hope to get out of this class:";

function updateMessage1() {

	var el1 = document.getElementById('message1');

	el1.textContent = msg1;
}

updateMessage1();

var msg2 = "An understanding of coding languages";

function updateMessage2() {

	var el2 = document.getElementById('message2');

	el2.textContent = msg2;
}

updateMessage2();

var msg3 = "The ability to work within a coding environment";

function updateMessage3() {

	var el3 = document.getElementById('message3');

	el3.textContent = msg3;
}

updateMessage3();

var msg4 = "Make new friends";

function updateMessage4() {

	var el4 = document.getElementById('message4');

	el4.textContent = msg4;
}

updateMessage4();



// Create a variable called el to hold the element whose id attribute has a value of info
var el = document.getElementById('info');
var randomNum = Math.floor((Math.random() * 10) + 1);

// Write the number into that element
el.innerHTML = '<h2>random number</h2><p>' + randomNum + '</p>';
