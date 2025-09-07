import "./RightSidePanel.css";

const RightSidePanel = ({hits, shots, time, gameOver}) => {
    return (
        <div className="right-panel-wraper">
            <div className="stats-wraper">
                <p className="stat-title">Ilosc Czasu</p>
                <p className="stat">{time}</p>
            </div>
            <div className="stats-wraper">
                <p className="stat-title">Liczba Trafionych</p>
                <p className="stat">{hits}</p>
            </div>
            <div className="stats-wraper">
                <p className="stat-title">Liczba Strzalow</p>
                <p className="stat">{shots}</p>
            </div>
            {shots !== 0 && (
            <>
                <div className="stats-wraper">
                    <p className="stat-title">Celnosc</p>
                    <p className="stat">{(hits/shots).toFixed(2)}</p>
                </div>
            </>
            )}
            {gameOver===true || shots>=10 && (
                <>
                    <h2 className="game-over">GAME OVER</h2>
                </>
            )}
        </div>
    );
};

export default RightSidePanel;