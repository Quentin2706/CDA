// API KEY 9BPUSD1lOCFRg94gfCRgWfyYG5tBx5oMxyLFigax
const requ = new XMLHttpRequest();
var grid = document.getElementById("grid");
var cpt = 35;

var boutons = document.getElementsByTagName("button");
boutons[0].addEventListener("click", function (){
    if (cpt > 0)
    {
        cpt--;
    }
    search();
});
boutons[1].addEventListener("click", function (){
    if (cpt < 35)
    {
    cpt++;
    }
    search();
});

function search()
{
requ.open('GET', 'https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=1000&page='+cpt+'&api_key=9BPUSD1lOCFRg94gfCRgWfyYG5tBx5oMxyLFigax', true);
requ.send();
}

search();

//Ajax
requ.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            grid.innerHTML="";
            //console.log("Réponse reçue: %s", this.responseText);;
            reponse=JSON.parse(this.responseText);

            reponse.photos.forEach(element => {
                console.log(element);
                let div = document.createElement("div");
                div.classList.add("colonne");
                
            let img = document.createElement("img");
            img.setAttribute("src", element.img_src);

            let date = document.createElement("div");
            date.textContent =  element.earth_date
                

            div.appendChild(img);
            div.appendChild(date)
            grid.appendChild(div);
            });
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

