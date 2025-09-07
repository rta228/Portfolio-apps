import { useEffect, useState } from 'react';
import './App.css'
import LeftSidePanel from './Components/LeftSidePanel';
import RightSidePanel from './Components/RightSidePanel';
import { getRandomInt} from './utils/utils';
import AimSights from './Components/aimSights';

function App() {
  const [top, setTop] = useState(0);
  const [left, setLeft] = useState(0);

  const [hits, setHits] = useState(0);
  const [shots, setShot] = useState(0);

  const [gameOver, setGameOver] = useState(false);
  const [time, setTime] = useState(3);
  const [countdown, setCountdown] = useState(null);

  const [gameWidth, setGameWidth] = useState(0);
  const [gameHeight, setGameHeight] = useState(0);

  const handleReset = () => {
    setHits(0);
    setShot(0);
    setTime(10);
    setTop(getRandomInt(gameHeight - 100));
    setLeft(getRandomInt(gameWidth - 100));
    setGameOver(false);
  }
  
  const timeout  = setTimeout(() => {
    countdown(true);
    handleGameOver(true)
  }, 3000)

  const handleTargetClick = () => {
    if(gameOver!==true && shots<10){
      setTop(getRandomInt(gameHeight - 100));
      setLeft(getRandomInt(gameWidth - 100));
      setHits(hits+1);
      setShot(shots+1);
      
      setCountdown(timeout);
    }else{
      handleGameOver(true)
    }
  }

  const handleGameOver = () => {
    setGameOver(true)
  }

  const handleShots = () => {
    if(gameOver!==true && shots<10){
      setShot(shots+1);
      setCountdown(timeout);
    }else{
      handleGameOver(true)
    }
  }

  useEffect(() => {
    const gameElement = document.getElementById('game-id');
    setGameHeight(gameElement.offsetHeight);
    setGameWidth(gameElement.offsetWidth);
  }, [])

  return (
    <div className='main-view-wrapper'>
      <div className='title-wraper'>
        <h1 className='title'>Mega Super Duper AimTrainer 2.0</h1>
      </div>
      <div className='game-wraper'>
        <LeftSidePanel handleReset={handleReset}/>
          {gameOver!==true && shots<10 && (
        <>
          <div 
            className='game' 
            id='game-id'
            onClick={handleShots}
          >
            <div 
              className='target'
              style={{
                top: `${top}px`,
                left: `${left}px`
              }}
              onClick={handleTargetClick}
            >
              <AimSights/>
            </div>
        </div>
        
        </>
        )}
        {gameOver==true || shots>=10 && (
        <>
          <div 
            className='game' 
            id='game-id'
          >
            <h1 className='title'>KONIEC GRY</h1>
        </div>
        
        </>
        )}
        <RightSidePanel
          hits={hits}
          shots={shots}
          time={time}
          gameOver={gameOver}
        />
      </div>
    </div>
  )
}

export default App
