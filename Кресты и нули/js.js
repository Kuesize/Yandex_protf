// Крестики начинают первые, массив с клетками поля
let currentPlayer = "X";
let gameBoard = ["", "", "", "", "", "", "", "", ""];
let gameActive = true;

// Условие для передачи хода
function handlePlayerTurn(clickedCellIndex) {
	if (gameBoard[clickedCellIndex] !== "" || !gameActive) {
		return;
	}
	gameBoard[clickedCellIndex] = currentPlayer;
	checkForWinOrDraw();
	currentPlayer = currentPlayer === "X" ? "O" : "X";
}

// Событие нажатия
function cellClicked(clickedCellEvent) {
	const clickedCell = clickedCellEvent.target;
	const clickedCellIndex = parseInt(clickedCell.id.replace("cell-", "")) - 1;
	if (gameBoard[clickedCellIndex] !== "" || !gameActive) {
		return;
	}
	handlePlayerTurn(clickedCellIndex);
	updateUI();
}

// Константа ячейки
const cells = document.querySelectorAll(".cell");

cells.forEach((cell) => {
	cell.addEventListener("click", cellClicked, false);
});

function updateUI() {
	for (let i = 0; i < cells.length; i++) {
		cells[i].innerText = gameBoard[i];
	}
}

// Победа
function announceWinner(player) {
	const messageElement = document.getElementById("gameMessage");
	messageElement.innerText = `Игрок ${player} победил!`;
}

// Ничья;
function announceDraw() {
	const messageElement = document.getElementById("gameMessage");
	messageElement.innerText = "Ничья!";
}

// Победные комбинации
const winConditions = [
	[0, 1, 2],
	[3, 4, 5],
	[6, 7, 8],
	[0, 3, 6],
	[1, 4, 7],
	[2, 5, 8],
	[0, 4, 8],
	[2, 4, 6],
];

// Проверка на победу или ничью
function checkForWinOrDraw() {
	let roundWon = false;

	for (let i = 0; i < winConditions.length; i++) {
		const [a, b, c] = winConditions[i];
		if (
			gameBoard[a] &&
			gameBoard[a] === gameBoard[b] &&
			gameBoard[a] === gameBoard[c]
		) {
			roundWon = true;
			break;
		}
	}

	// Если победил
	if (roundWon) {
		announceWinner(currentPlayer);
		gameActive = false;
		return;
	}

	// Если ничья
	let roundDraw = !gameBoard.includes("");
	if (roundDraw) {
		announceDraw();
		gameActive = false;
		return;
	}
}

// Кнопка рестарта полей и очистки массива
function resetGame() {
	gameBoard = ["", "", "", "", "", "", "", "", ""];
	gameActive = true;
	currentPlayer = "X";
	cells.forEach((cell) => {
		cell.innerText = "";
	});
	document.getElementById("gameMessage").innerText = "";
}

const resetButton = document.getElementById("resetButton");
resetButton.addEventListener("click", resetGame, false);
