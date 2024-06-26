# Задача
В компании разрабатывают программный продукт, который работает 24*7 в продакшен.
Работа над продуктом разделена между непересекающимися командами.
Продукт архитектурно состоит из фронтенда и двух бекендов (назовём их словом "сервис").
В каждой команде пристутствуют разработчики из этих сервисов.

Для того, чтобы продукт был стабильным, организованы так называемые дежурства: в каждом сервисе всегда есть 1 разработчик, который следит за состоянием сервиса и в случае ошибок оперативно разбирается и чинит их.
То же самое есть и в каждой команде - всегда есть 1 ответственный за командные компоненты.

Оба дежурства - сложные, требуют полной вовлечённости, поэтому разработчик не может одновременно дежурить на двух сразу.
Дежурства изматывают разработчиков, поэтому дежурные регулярно меняются.
Нежелательно, чтобы они дежурили слишком часто: дежурства должны быть распределены справедливо.

Людям свойственно ходить в отпуска, а иногда даже болеть! В эти дни они не могут дежурить.

Руководители команд и руководители сервисов - это разные люди.
Руководитель команды заинтересован в том, чтобы дежурства сервиса не сильно замедляли разработку продукта, поэтому хочется, чтобы дежурные от одной команды не дежурили на сервисе подряд.

Составлением графика дежурств занимается ответственный.
Те инструменты, которыми он пользуется не всегда учитывают все требования, поэтому ему нужен дополнительный инструмент, который:
1. примет на вход информацию о людях, их принадлежности к командам и сервисам, график их отпусков или болезней и текущий сформированный график дежурств
2. проверит правила, описанные выше
3. составит отчёт (пример смотри в файле example.md), в котором по неделям написано, кто где дежурит, сколько дней, кто болеет или отдыхает и список проблем в эту неделю