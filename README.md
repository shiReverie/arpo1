# Лабораторная №1 - Автоматизация разработки программного обеспечения
## 1. 
В Unity Hub создали проект на основе шаблона 2D Platformer Microgame. Проект открыли в Unity и убедились, что основная сцена открыта в активном окне
<img width="1302" height="938" alt="Снимок экрана (3604)" src="https://github.com/user-attachments/assets/02bf876f-b5c4-4033-bf06-6664f33c4063" />
## 2.
Внутри папки нашли папку Editor и создали в нем скрипт BuildManager.cs
## 3.
В Unity перешли в Edit → Project Settings → Player. Во вкладке с иконкой планеты/HTML5 развернули Publishing Settings
и отключили Compression Format

<img width="587" height="236" alt="Снимок экрана (3606)" src="https://github.com/user-attachments/assets/96f95f3d-3f21-422b-bcb3-fbe59b5142d7" />

## 4.
Проверили скрипт на наличие ошибок. Убедившись, что их нет, подождали пока перекомпилируется проект. 
В верхнем меню появился новый пункт Publish. Убедтлтсь, что сцена добавлена в Build Settings
## 5.
Открыли консоль и ввели команду для запуска автоматической сборки

<img width="1022" height="198" alt="Снимок экрана (3608)" src="https://github.com/user-attachments/assets/9d888501-a564-4447-bba9-31fa8cc281df" />

## 6.
После завершения работы скрипта убедились в логах, что билд успешно создан. В папке Builds/WebGL проверили появились ли скомпилированные веб-файлы

<img width="181" height="159" alt="Снимок экрана (3611)" src="https://github.com/user-attachments/assets/06dca4ef-d9c9-41aa-b0f0-ea4020166646" />

## 7.
Открыли билд проекта в VS Code и при помощи Live Server убедились, что игра работает

<img width="1321" height="870" alt="Снимок экрана (3613)" src="https://github.com/user-attachments/assets/bb503f8a-8b9a-404d-9b5a-a3a5a9bc5b1b" />

## 8. 

Создали .gitignore в корневой директории, иницилизировали репозиторий и зафиксировали базовое состояние проекта (без BuilManager.cs)

<img width="736" height="445" alt="Снимок экрана (3614)" src="https://github.com/user-attachments/assets/fc9aff9a-64e8-41bd-b1cb-be83782f5fd3" />

Привязали удалееный репозиторий GitHub и отправили туда ветку. Вернули Buildmanager.cs в Editor, переключились на новую ветку LR1, добавили изменения

<img width="755" height="437" alt="Снимок экрана (3617)" src="https://github.com/user-attachments/assets/64e9347c-8e6b-450b-8b46-82e19529af99" />

## 9.
Данный отчет зафиксировали отдельным коммитом. Добавили collaborators для дальнейшего ревью для апрува PR. В Compare & Pull Request 
создали PR (base - main, compare - LR1). В этом PR добавли reviewers. После получения двух Approve выполняем Merge pull requests
