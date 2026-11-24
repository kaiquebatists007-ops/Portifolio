# 📂 Tela de Projetos (`FrmProjetos`) — Portfólio (.NET / Windows Forms)

Formulário desenvolvido em **C#** com **Windows Forms (.NET Framework)** responsável por gerenciar a exibição, preview visual e execução externa dos mini projetos desenvolvidos no portfólio.

---

## 🚀 Funcionalidades
- **Seleção de Projetos (`cbProjetos`):** Permite escolher um projeto na lista suspensa e valida se alguma opção foi selecionada antes de carregar os dados.
- **Descrição Dinâmica (`listDescricao`):** Exibe o resumo e os objetivos do projeto escolhido em uma lista de itens.
- **Galeria Dinâmica de Imagens (`PictureBox`):** Instancia e posiciona previews das telas do projeto diretamente na interface via código, removendo e liberando memória (`Dispose`) das imagens anteriores a cada nova troca.
- **Execução de Aplicações Externas:** Utiliza `System.Diagnostics.Process` para localizar e iniciar o executável (`.exe`) compilado de projetos externos diretamente pelo portfólio.

---

## 📋 Projetos Mapeados no Código
- **Número Primo:** Exibe descrição detalhada, carrega 3 capturas de tela (`PrimeiraTela`, `SegundaTela`, `TerceiraTela`) a partir dos recursos (`Properties.Resources`) e permite executar o `NumeroPrimo.exe`.
- **Tabuada:** Estrutura preparada no `switch` com aviso de funcionalidade em desenvolvimento.

---

## 🧩 Principais Métodos Implementados
- `btnSelecionar_Click`: Valida a seleção, limpa a tela anterior, atualiza o título (`lblNomeProjeto`) e carrega a descrição e imagens correspondentes.
- `AdicionarTela(...)`: Cria componentes `PictureBox` em tempo de execução com coordenadas `(X, Y)`, dimensões personalizadas, borda e ajuste de imagem (`StretchImage`).
- `LimparTela()`: Percorre a lista `telasAtivas`, remove os controles visuais do formulário e libera recursos da memória.
- `ExecutarNumerPrimo()`: Resolve o caminho relativo a partir de `Application.StartupPath` até a pasta `bin\Debug` do projeto **Número Primo** e inicia o processo.
- `btnAchou()` / `btnSumiu()`: Controlam a visibilidade e habilitação do botão de execução (`btnExecutar`).

---

## 🛠️ Tecnologias e Namespaces Utilizados
- **Linguagem:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Namespaces Principais:** `System.Windows.Forms`, `System.Drawing`, `System.IO`, `System.Diagnostics`

---

## 👨‍💻 Autor
**Kaique Batista Ferreira**  
- GitHub: [@kaiquebatista007-ops](https://github.com)  
- LinkedIn: www.linkedin.com/in/kaique-batista-94a5a9308
