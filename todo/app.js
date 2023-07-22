// Get references to the HTML elements
const taskInput = document.getElementById('taskInput');
const addButton = document.getElementById('addButton');
const taskList = document.getElementById('taskList');
const colorButtons = document.querySelectorAll('.task-color');

// Function to add a new task to the list
function addTask() {
  const taskText = taskInput.value.trim();
  if (taskText !== '') {
    const selectedColor = getSelectedColor();
    const li = document.createElement('li');
    li.innerHTML = `
      <div class="pastel-colors">
        ${getPastelColorButtons()}
      </div>
      <span style="color:${selectedColor};">${taskText}</span>
      <span class="delete-button" onclick="deleteTask(this)">&times;</span>
    `;
    taskList.appendChild(li);
    taskInput.value = '';
  }
}

// Function to delete a task from the list
function deleteTask(deleteButton) {
  const taskItem = deleteButton.parentElement;
  taskList.removeChild(taskItem);
}

// Function to get the selected color
function getSelectedColor() {
  const checkedButton = document.querySelector('.task-color:checked');
  return checkedButton ? checkedButton.value : '#333';
}

// Function to get pastel color buttons
function getPastelColorButtons() {
  const pastelColors = ['#87CEFA', '#98FB98', '#FFB6C1', '#FFD700', '#FFA07A', '#E6E6FA'];
  let colorButtonsHTML = '';
  for (const color of pastelColors) {
    colorButtonsHTML += `
      <label class="color-selector">
        <input type="radio" name="color" class="task-color" value="${color}">
        <span class="task-color-label" style="background-color:${color};"></span>
      </label>
    `;
  }
  return colorButtonsHTML;
}

// Add event listener to the Add button
addButton.addEventListener('click', addTask);

// Enable adding a task by pressing Enter key
taskInput.addEventListener('keyup', function(event) {
  if (event.key === 'Enter') {
    addTask();
  }
});
