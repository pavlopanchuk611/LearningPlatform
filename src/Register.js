import React, { useState } from 'react';

const Register = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [message, setMessage] = useState('');

    const handleSubmit = async (e) => {
        e.preventDefault();
        setMessage(''); // Скидаємо повідомлення перед новим запитом

        try {
            const response = await fetch('https://localhost:5001/api/users', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ username, password, role: 'Student' })
            });

            if (response.ok) {
                setMessage('Реєстрація успішна!');
            } else {
                const errorData = await response.json();
                setMessage('Сталася помилка: ' + (errorData.message || 'Невідома помилка'));
            }
        } catch (error) {
            setMessage('Сталася помилка: ' + error.message);
        }
    };

    return (
        <div>
            <h2>Реєстрація</h2>
            <form onSubmit={handleSubmit}>
                <div>
                    <label>Ім'я користувача:</label>
                    <input
                        type="text"
                        placeholder="Username"
                        value={username}
                        onChange={(e) => setUsername(e.target.value)}
                        required
                    />
                </div>
                <div>
                    <label>Пароль:</label>
                    <input
                        type="password"
                        placeholder="Password"
                        value={password}
                        onChange={(e) => setPassword(e.target.value)}
                        required
                    />
                </div>
                <button type="submit">Зареєструватися</button>
            </form>
            {message && <p>{message}</p>}
        </div>
    );
};

export default Register;