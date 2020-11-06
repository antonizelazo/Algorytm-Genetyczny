# Algorytm-Genetyczny

	Problem badawczy:
Jakie boki powinien mieć trójkąt tak aby zmaksymalizować jego pole jednocześnie nie przekraczając wartości granicznej?

przykład głupi ale za to idealny do wyjaśnienia działania algorytmu xD


	Sprecyzowanie problemu
Jeżeli osobnik (trójkąt) ma ramiona które nie mogą utworzyć trójkąta to osobnik ginie i jego pole równa się 0
Jeżeli osobnik przekroczy wartość graniczną, jest za duży, żeby przeżyć więc ginie a jego pole równa się 0
Z każdej populacji wybierana jest tylko połowa która jest lepiej dopasowana do wartości granicznej reszta jest zastępowana nowymi osobnikami
Nowe osobniki tworzone są poprzez mutację osobników które pozostały
Mutacja polega na zmianie długości ramion osobnika poprzez wymnożenie długości każdego ramienia przez losową liczbę z przedziału (0.95 ; 1.05)


