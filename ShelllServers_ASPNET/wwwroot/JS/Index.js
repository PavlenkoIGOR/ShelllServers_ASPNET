document.addEventListener('mousemove', event => {
    Object.assign(document.documentElement, {
        style: `
        --move-x: ${(event.clientX - window.innerWidth / 2)*-0.005}deg;
        --move-y: ${(event.clientY - window.innerHeight / 2)*-0.01}deg;
        `
    })
})

/*показать окно для рекламы*/
let advRef = document.getElementsByClassName('nav-link');
for( var ref of advRef){
ref.addEventListener('click', Show);
	function Show(){
		for(var lnk of advRef){
			if(lnk.innerHTML == "Реклама сервера"){
				let advLink = document.getElementsByClassName('layers__advWindow')[0];
				advLink.style.display = "flex";
			}
		}
		console.log();
	};
}
