#include <windows.h>

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
	//MessageBox(hWnd, IpText, IpCaption, uType);
	//MessageBox(NULL, L"Komunikat na stronie", L"Tytul karty", MB_ICONINFORMATION | MB_OKCANCEL);
	// LPCWSTR - Long Pointer to Constant Wide String -> przed nim nalezy postawic L
	/*
	MessageBox(NULL, L"HWDP - z ang. Chwala Wam Dobrzy Policjanci", L"Prawda", MB_ICONINFORMATION | MB_OKCANCEL);
	*/

	const wchar_t NazwaKlasy[] = L"Klasa Okienka";
	WNDCLASSEX wndClass = { 0 };

	wndClass.cbSize = sizeof(WNDCLASSEX); //Rozmiar struktury w bajtach. Należy tu wpisać sizeof (WINDOWCLASSEX).

	wndClass.style = 0; //Nazwa mówi za siebie - style klasy.Dodam tylko, że NIE jest to to samo, co style okna, którymi zajmiemy się później.Tak więc wystarczy dać tu 0.

	wndClass.lpfnWndProc = NULL; //WndProc; //	Wskaźnik do procedury obsługującej okno (o tym później, na razie wpisujemy WndProc)

	wndClass.cbClsExtra = 0; //Dodatkowe bajty pamięci dla klasy (można ustawić na 0)
	wndClass.cbWndExtra = 0;

	wndClass.hInstance = hInstance; //Identyfikator aplikacji, która ma być właścicielem okna (zazwyczaj pierwszy parametr naszej funkcji WinMain)

	wndClass.hIcon = LoadIcon(NULL, IDI_APPLICATION); //Ikonka okna. Dokładniej: duża ikonka, widać ją kiedy naciśniesz Alt-Tab. Ładujemy ją poleceniem LoadIcon(NULL, IDI_APPLICATION), które wybierze nam domyślną ikonkę aplikacji.

	wndClass.hCursor = LoadCursor(NULL, IDC_ARROW); //	Kursor myszki. Analogicznie, jak dla ikonki, korzystamy z LoadCursor(NULL, IDC_ARROW), co zaowocuje pojawieniem się naszym okienku ślicznej strzałeczki :-).

	wndClass.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1); //	Tło naszego okienka, czyli jego kolor i wzór. Wybieramy domyślne, czyli zwykle szare tło - (HBRUSH)(COLOR_WINDOW + 1). Więcej o uchwycie HBRUSH poczytasz w rozdziale poświęconym grafice w WinAPI.

	wndClass.lpszMenuName = NULL; //Nazwa identyfikująca menu naszego okna w pliku zasobów. Na razie nie mamy żadnego menu, więc możemy dać NULL.

	wndClass.lpszClassName = NazwaKlasy; //Nazwa klasy, którą tworzymy

	wndClass.hIconSm = LoadIcon(NULL, IDI_APPLICATION); //Mała ikonka naszej aplikacji. Widać ją w rogu naszego okienka oraz na pasku zadań. Dajemy tutaj to samo, co w przypadku dużej ikony.

	if (!RegisterClassEx(&wndClass))
	{
		MessageBox(NULL, L"Wysoka Komisja odmawia rejestracji tego okna!", L"Niestety...",
			MB_ICONEXCLAMATION | MB_OK);
		return 1;
	}
	return 0;
}