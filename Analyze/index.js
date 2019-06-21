var gameloopId = setInterval(gameLoop, 10);

let lastLoop = new Date();
const fpsArray = [];

function gameLoop() {
    let thisLoop = new Date();
    let fps = 1000 / (thisLoop - lastLoop);
    lastLoop = thisLoop;
    fpsArray.push(fps);
}

setTimeout(() => {
    clearInterval(gameloopId);
    console.log(fpsArray);
}, 120000)