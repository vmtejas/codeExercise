import React from 'react';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemText from '@mui/material/ListItemText';
import Paper from '@mui/material/Paper';
import './LoginAttemptList.css';

const LoginAttemptList = ({ loginAttempts = [] }) => {
    return (
            <List>
                {loginAttempts.map((attempt, index) => (
                    <ListItem key={index} className="login-attempt-item">
                        <Paper elevation={1} className="login-attempt-paper">
                            <ListItemText primary={attempt.login} />
                        </Paper>
                    </ListItem>
                ))}
            </List>
    );
};

export default LoginAttemptList;
