let sim = ['*','/','-','+','.'];
let input = '';
let story = [];
let longStory = '';
let $input = document.querySelector('.input');
let $story = document.querySelector('.story');

$input.onkeyup = function(e){
	console.log(e)
	if(e.key == 'Enter')
		ev('=');
}

$input.oninput = function(e){
	ev(e.inputType == "deleteContentBackward" ? '<' : e.data);
	return false;
};

[...document.querySelectorAll('button')].forEach(function(el) {
	el.onclick = ev;
})

function ev(data) {
	let value = typeof data == 'string' ? data : this.attributes['inTo'].value;

	if(value == 'C'){
		if(!input && $input.value)
			input = $input.value;

		if(input)
			return $input.value = longStory = input = '';

		$story.innerHTML = '';
		return false;
	}

	if(value == '='){
		if(input != $input.value)
			input = $input.value;
		
		input = sim.includes(input[input.length-1]) ? input.slice(0, -1) : input;
		input = sim.includes(input[input.length-1]) ? input.slice(0, -1) : input;

		let string = longStory ? `(${longStory.split('=')[0]})${input.replace(longStory.split('=')[1], '')}` : input;
		let result = strToMath(string);
		
		longStory = `${string}=${result}`;
		story.push(`${input}=${result}`);
		$story.innerHTML += `<i>${story[story.length-1]}</i>`;
		input = $input.value = result;

		return false;
	}

	if(value == '<'){
		input = $input.value = input.slice(0, -1);
		return false;
	}

	if(story.length && value == '.' || !input && value == '.'){
		value = '0.';
	}

	if(sim.includes(input[input.length-1]) && sim.includes(value)){
		if(value != '-' && sim.includes(input[input.length-1]))
			input = input.slice(0, -1);
		if(value == '-' && input[input.length-1] == '-' || value == '-' && input[input.length-1] == '+')
			input = input.slice(0, -1);
		if(value != '-' && sim.includes(input[input.length-1]))
			input = input.slice(0, -1);
	}

	if(input == '' && sim.includes(value) && value != '-'){
		value = '';
	}

	if(story.length && !sim.includes(value)){
		input = '';
		longStory = '';
	}

	story = [];

	input += value;
	$input.value = input;
}



function strToMath(string){
	string = string.replaceAll(' ', '').replaceAll('+', ' + ').replaceAll('*', ' * ').replaceAll('-', ' - ').replaceAll('/', ' / ').split(' ');
	
	for(let i = 0; i < string.length; i++){
		if(string[i] == ''){
			string.splice(i, 2);
			string[i] = '-'+string[i];
		}
	}
	
	let calc = document.createElement('calc');
	calc.style['opacity'] = `calc(${string.join(' ')})`;
	let result = parseFloat(calc.style['opacity'].replace('calc(', '').replace(')', ''))
	calc.remove();

	return result;
}