#include <iostream>
#include <Windows.h>
#include <stdio.h>
using namespace std;

// Identyfikator pola tekstowego
#define IDC_TEXTBOX1 102
#define IDC_TEXTBOX2 103
#define ID_QUIT 120


HWND label;
// Funkcja obslugujaca przycisk
LRESULT CALLBACK ButtonProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    switch (message)
    {
    case WM_COMMAND:
        if (LOWORD(wParam) == ID_QUIT) {
            MessageBox(NULL, L"Jakies cos", L"Help", MB_OK);
            const wchar_t* messageText = L"Po kliku mamy zmiany :D";
            SetWindowText(label, messageText);
        }
    {

    }
    break;

    case WM_CLOSE:
        // Obsluguje zamkniecie okna
        DestroyWindow(hwnd);
        break;

    case WM_DESTROY:
        // Obsluguje zakonczenie aplikacji
        PostQuitMessage(0);
        break;

    default:
        return DefWindowProc(hwnd, message, wParam, lParam);
    }

    return 0;
}



int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
    // Inicjalizacja aplikacji
    WNDCLASSEX wc = { sizeof(WNDCLASSEX), CS_HREDRAW | CS_VREDRAW, ButtonProc, 0, 0, GetModuleHandle(NULL), NULL, NULL, NULL, NULL, L"MyClass", NULL };

    RegisterClassEx(&wc);

    //formatka
    HWND hwnd = CreateWindow(L"MyClass", L"Pole tekstowe", WS_OVERLAPPEDWINDOW, 100, 100, 1000, 400, NULL, NULL, GetModuleHandle(NULL), NULL);


    // Tworzenie etykiety
    label = CreateWindow(L"STATIC", L"Hello", WS_TABSTOP | WS_VISIBLE | WS_CHILD | WS_BORDER, 10, 10, 250, 50, hwnd, (HMENU)IDC_TEXTBOX1, hInstance, NULL); 
    CreateWindow(L"STATIC", L"World", WS_TABSTOP | WS_VISIBLE | WS_CHILD | WS_BORDER, 300, 10, 250, 50, hwnd, (HMENU)IDC_TEXTBOX2, hInstance, NULL);
    CreateWindow(L"BUTTON", L"Kliklnij mnie",WS_VISIBLE | WS_CHILD, 500, 200, 250, 50, hwnd, (HMENU)ID_QUIT, NULL, NULL);




    // Wyswietlenie okna
    ShowWindow(hwnd, nCmdShow);
    UpdateWindow(hwnd);

    const wchar_t* messageText = L"Czyli co kolwiek tu wpisze to sie wysweitlitam?";

    MessageBox(hwnd, messageText, L"MessageBox", MB_OK);

    // Ustaw zawartosc pola statycznego (labela)
    SetWindowText(label, messageText);


    // Petla komunikatów
    MSG msg;
    while (GetMessage(&msg, NULL, 0, 0))
    {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }
    return msg.wParam;
}