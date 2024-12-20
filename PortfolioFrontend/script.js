document.addEventListener("DOMContentLoaded", () => {
    fetch("http:localhost:5000/api/experience")
    .then((response)=> response.json())
    .then((data)=> renderExperience(data));
});

function renderExperience(data){
    const container = document.getElementById("content")
}