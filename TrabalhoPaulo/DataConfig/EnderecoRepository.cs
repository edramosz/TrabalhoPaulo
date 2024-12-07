﻿using Core._02_Repository.Interfaces;
using Core._03_Entidades;

namespace API.DataConfig
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly ApplicationDbContext _context;
        public EnderecoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Endereco e)
        {
            _context.Enderecos.Add(e);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            Endereco end = _context.Enderecos.Find(id);
            _context.Enderecos.Remove(end);
            _context.SaveChanges();
        }
        public void Editar(Endereco e)
        {
            _context.Enderecos.Update(e);
            _context.SaveChanges();
        }
        public List<Endereco> Listar()
        {
            return _context.Enderecos.ToList();
        }
        public Endereco BuscarEnderecoPorId(int id)
        {
            return _context.Enderecos.Find(id);
            
        }
    }
}
