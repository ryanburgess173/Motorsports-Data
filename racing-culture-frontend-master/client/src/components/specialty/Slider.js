import { useEffect, useState } from "react";

let stories = [
    { "image": "https://racing-culture.s3.amazonaws.com/imsa-1.jpg", "title": "IMSA Porsche Team looking forward to 2022 Season" },
    { "image": "https://racing-culture.s3.amazonaws.com/f1-1.jpg", "title": "What to expect during 2022 F1 world championship" },
    { "image": "https://racing-culture.s3.amazonaws.com/indycar-1.jpg", "title": "Get tickets to 2022 Grand Prix of Long Beach" },
    { "image": "https://racing-culture.s3.amazonaws.com/nascar-xfinity-1.jpg", "title": "XFinity drivers looking forward to Bristol in 2022" }
];
export default function Slider(props){
    const [currentStory, setCurrentStory] = useState(0);
    useEffect(()=>{
        setInterval(()=>{changeStory(currentStory, setCurrentStory)}, 5000);
        console.log(currentStory);
    });
    return (
        <div>
            <img src={stories[currentStory].image}/>
            <h2>{stories[currentStory].title}</h2>
        </div>
    );
}
function changeStory(currentStory, setCurrentStory){
    if(currentStory === (stories.length-1)){
        //currentStory = 0;
        setCurrentStory(0);
    }else{
        //currentStory++;
        setCurrentStory(currentStory++);
    }
}