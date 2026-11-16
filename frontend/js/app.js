const url = "http://localhost:5277/api/";

const button = document.getElementById("APIButton");
const message = document.getElementById("APIMessage");

const addForm = document.getElementById("add-form");
const inputOne = document.getElementById("number-one");
const inputTwo = document.getElementById("number-two");
const addOutput = document.getElementById("add-output");

const additionFetch = async (numberOne, numberTwo) => {
    const response = await fetch(`${url}math/addition/${numberOne}/${numberTwo}`);
    const data = await response.json();
    console.log(data);
    return data;

}

additionFetch(5, 60);

const APIFetch = async () => {
    //We need to await our fetch & store it in a variable
    const res = await fetch(url + "health/json");
    const data = await res.json();
    console.log(data);
    return data.message;
}

APIFetch();


button.addEventListener("click", async () => {
      
    message.textContent = await APIFetch();
});

addForm.addEventListener("submit", async (event) => {
      event.preventDefault();

      const output = await additionFetch(inputOne.value, inputTwo.value);

      addOutput.textContent = `${output.numOne} + ${output.numTwo} = ${output.result}`;
});