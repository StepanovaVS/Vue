<template>
    <v-row>
        <v-data-table
            :headers="headers"
            :items="cafes"
            :items-per-page="7" class="elevation-1">
        </v-data-table>
    </v-row>
</template>

<script>
export default {
    data () {
        return {
            headers: [
                {
                    text: '№',
                    align: 'start',
                    sortable: false,
                    value: 'id'
                },
                {
                    text: 'Время', value: 'time'
                },
                {
                    text: 'Описание', value: 'description'
                }
            ],
        cafes: [
            {
                id: 1,
                time: '7:30',
                description: 'Подъем'
            },
            {
                id: 2,
                time: '8:30',
                description: 'Завтрак'
            },
            {
                id: 3,
                time: '9:00',
                description: 'Сборы'
            },
            {
                id: 4,
                time: '9:50',
                description: 'Выхожу из дома'
            },
            {
                id: 5,
                time: '10:26',
                description: 'Сажусь в автобус'
            },
            {
                id: 6,
                time: '10:45',
                description: 'Пересадка'
            },
            {
                id: 7,
                time: '11:10',
                description: 'Иду в колледж'
            },
            {
                id: 8,
                time: '14:50',
                description: 'Выхожу их колледжа'
            },
            {
                id: 9,
                time: '15:10',
                description: 'Сажусь в маршрутку'
            },
            {
                id: 10,
                time: '15:50',
                description: 'Пересадка'
            },
            {
                id: 11,
                time: '16:30',
                description: 'Иду в магазин'
            },
            {
                id: 12,
                time: '17:50',
                description: 'Еду домой'
            },
            {
                id: 13,
                time: '18:10',
                description: 'Дома'
            },
            {
                id: 14,
                time: '18:15',
                description: 'Кормлю животных'
            },
            {
                id: 15,
                time: '18:30',
                description: 'Ем'
            },
            {
                id: 16,
                time: '19:30',
                description: 'Долги'
            },
            {
                id: 17,
                time: '20:50',
                description: 'Уборка'
            },
            {
                id: 18,
                time: '21:15',
                description: 'Учеба'
            },
            {
                id: 19,
                time: '22:00',
                description: 'YouTube'
            },
            {
                id: 20,
                time: '23:00',
                description: 'Долги'
            },
            {
                id: 21,
                time: '1:30',
                description: 'Сон'
            }
        ]
    }
    }
}
</script>
