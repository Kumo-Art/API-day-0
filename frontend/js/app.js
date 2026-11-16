const url = "http://localhost:5277/api/health/json";

const button = document.getElementById("APIButton");
const message = document.getElementById("APIMessage");

const APIFetch = async () => {
    //We need to await our fetch & store it in a variable
    const res = await fetch(url);
    const data = await res.json();
    console.log(data);
    return data.message;
}

APIFetch();


button.addEventListener("click", async () => {
      
    message.textContent = await APIFetch();
})