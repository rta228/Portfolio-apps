import "./LeftSidePanel.css";

const LeftSidePanel = ({handleReset}) => {
    return (
        <div className="left-panel-wraper">
            <button 
                className="reset-button"
                onClick={handleReset}
            >
                RESET
            </button>
        </div>
    );
};

export default LeftSidePanel;