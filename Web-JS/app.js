'use strict';

let uCase = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
let lCase = 'abcdefghijklmnopqrstuvwxyz';
let numbers = '0123456789';
let special = '!#$%&()*+-.=?@_';

// Получаем все элементы
let toggle = document.querySelectorAll('#toggle');
let generate = document.getElementById('generate');
let text = document.getElementById('passes');

// Получаем длину пароля (по идее не должна превышать 255 символов)
let lengthForPass = toggle[4];

// Длина словаря
var generalString = '';

// Отслеживание чекбоксов
let events = (index, literal, regexp) => {
	toggle[index].addEventListener('click', () => {
		if (toggle[index].checked === true) {
			generalString += literal;
		} else {
			generalString = generalString.replace(regexp, '');
		}
	});
};

events(0, uCase, /[A-Z]/g);
events(1, lCase, /[a-z]/g);
events(2, numbers, /[0-9]/g);
events(3, special, /[^A-Za-z0-9]/g);

// Функция-рандомайзер
function random(min, max) {
	return Math.floor(Math.random() * (max - min) + min);
}

// Функция-генератор
let pass = '';
generate.onclick = function generatePassw() {
	for (let i = 0; i < 20; i++) {
		for (let j = 0; j <= lengthForPass.value; j++) {
			let index = random(0, generalString.length);
			let SymChar = generalString[index];
			pass += SymChar;
			pass = pass.replace('undefined', '');
		}
		text.innerHTML = pass += '\n\n';
	}
	pass = '';
};
