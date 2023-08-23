document.addEventListener('mousemove', event => {
    Object.assign(document.documentElement, {
        style: `
        --move-x: ${(event.clientX - window.innerWidth / 2)*-0.005}deg;
        --move-y: ${(event.clientY - window.innerHeight / 2)*-0.01}deg;
        `
    })
})


let modalWindows = document.getElementsByClassName('modalWindow');

/*показать окно для рекламы*/
let advRef = document.getElementsByClassName('nav-link');

for( var ref of advRef){
	if(ref.innerHTML == "Реклама сервера"){
		ref.addEventListener('click', ShowAdwWindow);
	}
	if(ref.innerHTML == "DISCORD"){
		ref.addEventListener('click', ShowDiscord);
	}
	else{}
}

/*делает все модальные невидимыми*/
function HideModals(){
	for(var modal of modalWindows){
		modal.style.display = "none";
	}
}

/*функция показа модального для дискорда*/
function ShowDiscord(){
	HideModals();
	let discordWin = document.getElementById('layers__chatBotWindow');
	discordWin.style.display = "block";
}

let position=0;
/*функция показа модального для рекламы*/
function ShowAdwWindow(){
	HideModals();
	let advWin = document.getElementById('layers__advWindow');
	advWin.style.display = "flex";
	Scroll();
}



function Scroll(){
	let elem = document.getElementsByClassName('divFor')[0];
	elem.addEventListener('wheel', function(e) {
		let innerDivADV = document.getElementsByClassName('innerDivADV')[0];
		if(e.wheelDelta >= 0)
		{
			position +=40;
			innerDivADV.style.transform = `translateY(${position}px)`;
		}
		else{
		position -=40;
			innerDivADV.style.transform = `translateY(${position}px)`;
		}
	})
}
