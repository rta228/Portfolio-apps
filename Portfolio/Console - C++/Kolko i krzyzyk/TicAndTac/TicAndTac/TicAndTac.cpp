#include <iostream>
using namespace std;

class TicTacBoard {
private:
	int board[3][3] = { // 0 - Puste, 1 - X, 2 - O
		{0,0,0},
		{0,0,0},
		{0,0,0}
	};
	int moveCounter=0;
	bool isGameRunning=false;
	int whoseMoveIsIt=1; //1-X, 2-O
	int x, y;
public:
	TicTacBoard();

	void createBoard() {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				if (board[i][j] == 0) {
					cout << "|_|";
				}
				else if (board[i][j] == 1) {
					cout << "|X|";
				}
				else if (board[i][j] == 2) {
					cout << "|O|";
				}
			}
			cout << endl;
		}
	}

	void boardCleanUp() {
		for (int i = 0; i < 3; i++) {
			for (int j = 0; j < 3; j++) {
				board[i][j] = 0;
			}
		}
	}

	bool checker(int val) {
		if (val < 0 or val>2) {
			return false;
		}return true;
	};

	void move() {
		x = -1; y = -1;
		cout << "Wprowadz swoj ruch!\nX: "; cin >> x;
		cout << "Y: "; cin >> y;

		if (!checker(x) || !checker(y)) {
			cout << "Wartosci x,y musza byc z przedzialu 0-2!"<<endl;
			move();
		}

		switch (whoseMoveIsIt) {
		case 1:
			if (fieldIsOccupied(x, y)) {
				board[x][y] = 1;
				whoseMoveIsIt = 2;
				break;
			}break;
		case 2:
			if (fieldIsOccupied(x, y)) {
				board[x][y] = 2;
				whoseMoveIsIt = 1;
				break;
			}break;
		}
	}

	int fieldIsOccupied(int x, int y) {
		if (board[x][y] != 0) {
			system("cls");
			cout << "To pole jest juz zajete!"<<endl;
			createBoard();
			move();
			return false;
		} return true;
	}

	void play() {
		isGameRunning = true;
		moveCounter = 0;
		while(endGame()) {
			system("cls");
			createBoard();
			move();
		}
	}

	int win() {
		return 0;
	}

	bool endGame() {
		if (isGameRunning) {
			if (moveCounter >= 9) {
				system("cls");
				cout << "Remis!\nKoniec ruchow!"<<endl;
				createBoard();
				isGameRunning = false;
				wybor();
				return false;
			}
			else if (win()!=0) {
				system("cls");
				cout << "\nGracz "<<win()<<" wygral!";
				createBoard();
				isGameRunning = false;
				wybor();
				return false;
			}
			moveCounter++;
			return true;
		}
	}

	void wybor() {
		int wyb;
		cout << "\nZagraj 1 "; cin >> wyb;
		play();
	}

};

TicTacBoard::TicTacBoard() {
	cout << "/ Tic Tac Toe \\" << endl;
	wybor();
};



int main()
{
	TicTacBoard ticTacBoard;
}
