import React from 'react';
import Slider from '../specialty/Slider';
import Header from '../base/Header';
import MainContainer from '../base/MainContainer';
import Footer from '../base/Footer';

export default function Home(props){
    const pageContent = (
        <Slider/>
    );
    return(
        <div>
            <Header/>
            <MainContainer content={pageContent}/>
            <Footer/>
        </div>
    );
}