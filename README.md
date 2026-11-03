# Лабораторная №3 - Контейнеризация веб-сервера в Docker и раздача сжатых файлов со стороны Nginx
## 1. 
В Unity поменяли настройки билда проекта: в сжатии поменяли disabled на gzip
## 2.
Создали файл nginx.config

<img width="706" height="896" alt="Снимок экрана (3854)" src="https://github.com/user-attachments/assets/ed5c9784-4b3a-4873-9445-6ff0c3a29d24" />

## 3.
Создали Dockerfile. Запрограммировали в нем удаление стандартных настроек Nginx и
копирование кастомных файлов

<img width="925" height="613" alt="Снимок экрана (3855)" src="https://github.com/user-attachments/assets/4ccb3930-4e2b-48bd-9207-348ccc7843fe" />

## 4.
Собрали образ игры, запустили контейнер на порту 8080

<img width="1600" height="900" alt="Снимок экрана (3858)" src="https://github.com/user-attachments/assets/4033995a-a869-419a-84bf-26377310bcb0" />

<img width="1605" height="875" alt="Снимок экрана (3859)" src="https://github.com/user-attachments/assets/ed87b03d-f537-490b-8a3f-cf3d2fd0ce2e" />

<img width="1764" height="954" alt="Снимок экрана (3860)" src="https://github.com/user-attachments/assets/bc9741c1-d928-4f8a-aaa9-210f53345595" />

<img width="676" height="269" alt="Снимок экрана (3861)" src="https://github.com/user-attachments/assets/92d3a667-3217-4676-a629-0c6192c390b9" />

## 5.
Чтобы этот механизм собирался на серверах GitHub, добавили 3 шаг в main.yml. Проверили, что все работает на GitHub

<img width="262" height="100" alt="image" src="https://github.com/user-attachments/assets/40f8fd46-de16-4c7f-b23c-06293701880b" />

# Лабораторная №4 - Автоматизация тестирования (Unity Test Runner) в CI/CD

## 1.
В проекте создали GameAssembly, который является Assembly Definition
## 2.
Создали папки для тестов (для edit и play mode) и в них же соответсвующие тесты через window → Test runner

<img width="424" height="337" alt="Снимок экрана (3867)" src="https://github.com/user-attachments/assets/048805bc-cf16-4ce1-8f9f-058fdb893d86" />

## 3.
Написали 3 автоматических теста. Для play mode тест - Increment() повышает HP на 1, но не выше maxHP. Для edit mode - тест с методички. Тесты проверили
через Test runner

<img width="400" height="232" alt="Снимок экрана (3872)" src="https://github.com/user-attachments/assets/3abf64d4-6c5b-402c-a26f-234de31a3c0a" />

<img width="409" height="292" alt="Снимок экрана (3873)" src="https://github.com/user-attachments/assets/0c87b6ab-a647-4ab1-9439-db9659a9040e" />

## 4.
Чтобы тесты запускались в облаке при каждом git push, обновили main.yml

## 5.
В секреты репозитория добавили unity license, email и password

<img width="1236" height="416" alt="Снимок экрана (3874)" src="https://github.com/user-attachments/assets/d11ce790-86e3-479d-9a0e-4cf73f5006e7" />

## 6.
Запушили на GitHub проверили, что тесты прошли проверку

<img width="1407" height="397" alt="Снимок экрана (3876)" src="https://github.com/user-attachments/assets/b71f6d86-c192-4dd6-8b0b-bb6d8b2cf2df" />

