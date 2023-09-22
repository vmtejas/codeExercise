import React, { useState } from 'react';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemText from '@mui/material/ListItemText';
import Paper from '@mui/material/Paper';
import TextBox from './components/TextBox';
import './LoginAttemptList.css';

const LoginAttemptList = ({ loginAttempts = [] }) => {
    const [searchTerm, setSearchTerm] = useState('');

    const filteredAttempts = loginAttempts.filter(attempt => attempt.login.toLowerCase().includes(searchTerm.toLowerCase()));

    return (
        <div className="attempt-list">
            <TextBox
                label="Filter"
                value={searchTerm}
                onChange={(e) => setSearchTerm(e.target.value)}
                style={{ marginBottom: '20px' }}
            />
            <List>
                {filteredAttempts.map((attempt, index) => (
                    <ListItem key={index} className="login-attempt-item">
                        <Paper elevation={1} className="login-attempt-paper">
                            <ListItemText primary={attempt.login} />
                        </Paper>
                    </ListItem>
                ))}
            </List>
        </div>
    );
};

export default LoginAttemptList;
