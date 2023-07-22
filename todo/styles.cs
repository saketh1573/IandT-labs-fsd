body {
  font-family: Arial, sans-serif;
  margin: 0;
  padding: 0;
  background-color: #f9f9f9;
}

.header-container {
  padding: 20px;
  text-align: center;
  background-color: #FFD700; /* Pink Pastel background color */
}

.header-title {
  font-size: 32px;
  color: #87CEFA; /* Light Blue Pastel color for header */
  margin: 0;
}

.container {
  max-width: 400px;
  margin: 30px auto;
  padding: 20px;
  background-color: #fff;
  border-radius: 5px;
  box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
}

.input-container {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 10px;
}

input[type="text"] {
  flex-grow: 1;
  padding: 10px;
  font-size: 16px;
  border: 1px solid #ccc;
  border-radius: 5px;
}

button {
  padding: 10px 20px;
  font-size: 16px;
  background-color: #4CAF50;
  color: #fff;
  border: none;
  border-radius: 5px;
  cursor: pointer;
}

button:hover {
  background-color: #45a049;
}

ul {
  list-style: none;
  padding: 0;
}

li {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 10px;
  border-bottom: 1px solid #ccc;
}

li:last-child {
  border-bottom: none;
}

.delete-button {
  color: #f44336;
  font-size: 18px;
  cursor: pointer;
}

/* Task colors */
.task-color {
  display: none;
}

.color-selector {
  display: flex;
  align-items: center;
}

.task-color-label {
  width: 30px;
  height: 30px;
  border-radius: 50%;
  cursor: pointer;
  margin-left: 5px;
  border: 2px solid transparent;
  transition: border 0.3s ease-in-out;
}

.task-color-label:hover {
  border: 2px solid #333;
}

.pastel-colors {
  display: flex;
  align-items: center;
  justify-content: center;
}

.color-options {
  display: flex;
  align-items: center;
  justify-content: center;
  margin-bottom: 10px;
}

.color-option {
  width: 30px;
  height: 30px;
  border-radius: 50%;
  margin-left: 5px;
  cursor: pointer;
}
